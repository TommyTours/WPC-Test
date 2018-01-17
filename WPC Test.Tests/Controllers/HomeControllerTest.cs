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
        HomeController controller = new HomeController();

        [TestMethod]
        public void Index()
        {
            // Arrange
            

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetLocation()
        {
            var result = controller.GetLocationByPostcode("BS20PT");
        }

        [TestMethod]
        public void GetLocationCorrectType()
        {
            var result = controller.GetLocationByPostcode("BS20PT");

            Assert.IsInstanceOfType(result, typeof(Location));
        }

        [TestMethod]
        public void GetLatitude()
        {
            var result = controller.GetLocationByPostcode("BS20PT");
            Assert.AreEqual((double)51.4528587168519, result.Latitude);
        }

        [TestMethod]
        public void GetLongitude()
        {
            var result = controller.GetLocationByPostcode("BS20PT");
            Assert.AreEqual((double)-2.58337759979648, result.Longitude);
        }
    }
}
