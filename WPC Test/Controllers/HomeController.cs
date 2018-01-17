using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WPC_Test.Helpers;
using WPC_Test.Models;

namespace WPC_Test.Controllers
{
    public class HomeController : Controller
    {
        private static readonly WebClient SynClient = new WebClient();

        public ActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel model)
        {
            ModelState.Clear();

            Location locationToSearch = GetLocationByPostcode(model.postcode);

            return View(
                new HomeViewModel() {crimesByCategory = GetCrimesByLatLongAndDate(locationToSearch, new DateTime(model.year, model.month, 28))});
        }

        public List<List<JSONCrime>> GetCrimesByLatLongAndDate(Location locationToSearch, DateTime dateToSearch)
        {
            var json = SynClient.DownloadString($"https://data.police.uk/api/crimes-street/all-crime?lat={locationToSearch.Latitude}&lng={locationToSearch.Longitude}&date={dateToSearch.Year}-{dateToSearch.Month}");

            List<JSONCrime> crimesFromJson = JsonConvert.DeserializeObject<List<JSONCrime>>(json);

            var crimesByCategory = new List<List<JSONCrime>>();

            foreach (var crimeCategory in crimesFromJson.Select(a => a.category).Distinct())
            {
                crimesByCategory.Add((from crime in crimesFromJson where crime.category == crimeCategory select crime).ToList());
            }

            return crimesByCategory;
        }

        public Location GetLocationByPostcode(string postcode)
        {
            var json = SynClient.DownloadString($"https://api.postcodes.io/postcodes/{postcode}");

            dynamic locationData = JsonConvert.DeserializeObject<dynamic>(json);

            Location locationToReturn = new Location()
            {
                Latitude = locationData.result.latitude,
                Longitude = locationData.result.longitude
            };

            return locationToReturn;
        }
    }

}