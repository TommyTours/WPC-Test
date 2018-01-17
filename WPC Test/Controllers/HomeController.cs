using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WPC_Test.Helpers;

namespace WPC_Test.Controllers
{
    public class HomeController : Controller
    {
        private static readonly WebClient synClient = new WebClient();

        public ActionResult Index()
        {
            return View();
        }

        public Location GetLocationByPostcode(string postcode)
        {
            var content = synClient.DownloadString($"https://api.postcodes.io/postcodes/{postcode}");

            dynamic locationData = JsonConvert.DeserializeObject<dynamic>(content);

            Location locationToReturn = new Helpers.Location()
            {
                Latitude = locationData.result.latitude,
                Longitude = locationData.result.longitude
            };

            return locationToReturn;
        }
    }

}