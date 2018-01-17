using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WPC_Test.Helpers;

namespace WPC_Test.Controllers
{
    public class HomeController : Controller
    {
        private static WebClient synClient = new WebClient();

        public ActionResult Index()
        {
            return View();
        }

        public Location GetLocationByPostcode(string postcode)
        {
            var content = synClient.DownloadString($"https://api.postcodes.io/postcodes/{postcode}");

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Location));

            Location locationData;

            using (MemoryStream memStream = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                locationData = (Location) serializer.ReadObject(memStream);
            }

            return locationData;
        }
    }
}