using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenWeatherAPI.Models;

namespace OpenWeatherAPI.UnitTests.Models.UnitTests
{
    [TestClass]
    public class LocationModelTests
    {
        private string jsonInput = "{\"id\": 756135,\"name\":\"Warsaw\",\"country\": \"PL\",\"coord\": {\"lon\": 21.01178,\"lat\": 52.229771}}";

        [TestMethod]
        public void LocationModel_Scenario_CheckIdProperty_Returns756135()
        {
            //Arrange
            string jsonLocation = jsonInput;

            //Act
            LocationModel location = JsonConvert.DeserializeObject<LocationModel>(jsonLocation);
            int actualLocationId = location.Id;

            int expectedLocationId = 756135;

            //Assert
            Assert.AreEqual(actualLocationId, expectedLocationId);


        }

        [TestMethod]
        public void LocationModel_Scenario_CheckNameProperty_ReturnsWarsaw()
        {
            //Arrange
            string jsonLocation = jsonInput;

            //Act
            LocationModel location = JsonConvert.DeserializeObject<LocationModel>(jsonLocation);
            string actualLocationName = location.Name;

            string expectedLocationName = "Warsaw";

            //Assert
            Assert.AreEqual(actualLocationName, expectedLocationName);


        }

        [TestMethod]
        public void LocationModel_Scenario_CheckCountryProperty_ReturnsPL()
        {
            //Arrange
            string jsonLocation = jsonInput;

            //Act
            LocationModel location = JsonConvert.DeserializeObject<LocationModel>(jsonLocation);
            string actualLocationCountry = location.Country;

            string expectedLocationCountry = "PL";

            //Assert
            Assert.AreEqual(actualLocationCountry, expectedLocationCountry);


        }

        [TestMethod]
        public void LocationModel_Scenario_CheckFullLocationMethod_ReturnsWarsawPL756135()
        {
            //Arrange
            string jsonLocation = jsonInput;

            //Act
            LocationModel location = JsonConvert.DeserializeObject<LocationModel>(jsonLocation);
            string actualLocationFullLocation = location.FullLocation;

            string expectedLocationFullLocation = "Warsaw, PL - 756135";

            //Assert
            Assert.AreEqual(actualLocationFullLocation, expectedLocationFullLocation);


        }

    }
}
