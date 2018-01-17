using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPC_Test;
using WPC_Test.Controllers;
using WPC_Test.Helpers;
using Location = WPC_Test.Helpers.Location;

namespace WPC_Test.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private readonly HomeController _controller = new HomeController();

        private readonly Location _testLocation = new Location
        {
            Latitude = 51.4528587168519,
            Longitude = -2.58337759979648
        };

        private readonly DateTime _testTime = new DateTime(2017, 6, 30);

        [TestMethod]
        public void Index()
        {
            // Arrange
            

            // Act
            ViewResult result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetLocation()
        {
            var result = _controller.GetLocationByPostcode("BS20PT");
        }

        [TestMethod]
        public void GetLocationCorrectType()
        {
            var result = _controller.GetLocationByPostcode("BS20PT");

            Assert.IsInstanceOfType(result, typeof(Location));
        }

        [TestMethod]
        public void GetLatitude()
        {
            var result = _controller.GetLocationByPostcode("BS20PT");
            Assert.AreEqual((double)51.4528587168519, result.Latitude);
        }

        [TestMethod]
        public void GetLongitude()
        {
            var result = _controller.GetLocationByPostcode("BS20PT");
            Assert.AreEqual((double)-2.58337759979648, result.Longitude);
        }

        //https://data.police.uk/api/crimes-street/all-crime?lat=51.4528587168519&lng=-2.58337759979648&date=2017-06
        [TestMethod]
        public void GetCrimes()
        {
            var result = _controller.GetCrimesByLatLongAndDate(_testLocation, new DateTime(2017, 6, 30));
        }

        [TestMethod]
        public void getCrimesCorrectType()
        {
            var result = _controller.GetCrimesByLatLongAndDate(_testLocation, new DateTime(2017, 6, 30));
            Assert.IsInstanceOfType(result, typeof(List<List<JSONCrime>>));
        }

        [TestMethod]
        public void getCrimesCorrectNumberOfCategories()
        {
            var result = _controller.GetCrimesByLatLongAndDate(_testLocation, new DateTime(2017, 6, 30));
            Assert.AreEqual(14, result.Count);
        }
    }
}
