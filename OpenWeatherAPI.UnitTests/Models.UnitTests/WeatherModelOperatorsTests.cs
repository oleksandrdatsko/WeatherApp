using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenWeatherAPI.Models;

namespace OpenWeatherAPI.UnitTests.Models.UnitTests
{
    [TestClass]
    public class WeatherModelOperatorsTests
    {

        private string jsonWeatherResponse = "";

        private void ReadWeatherResponseJson()
        {
            using (StreamReader streamReader = new StreamReader(@"D:\Visual Studio Projects\MVVM_WPF\OpenWeatherAPI.UnitTests\Resources\SampleWeatherResponse.json"))
            {
                jsonWeatherResponse = streamReader.ReadToEnd();
            }
        }

        #region sys

        [TestMethod]
        public void WeatherModel_Scenario_CheckSys_CountryOperatorEquals_ReturnTrue()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualCountry = weather.sys.Country;
            string expectedCountry = "AU";
            bool comparisonResult = (actualCountry == expectedCountry);

            //Assert
            Assert.IsTrue(comparisonResult);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckSys_CountryOperatorEquals_ReturnFalse()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualCountry = weather.sys.Country;
            string expectedCountry = "PL";
            bool comparisonResult = (actualCountry == expectedCountry);

            //Assert
            Assert.IsFalse(comparisonResult);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckSys_CountryOperatorNotEquals_ReturnTrue()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualCountry = weather.sys.Country;
            string expectedCountry = "PL";
            bool comparisonResult = (actualCountry != expectedCountry);

            //Assert
            Assert.IsTrue(comparisonResult);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckSys_CountryOperatorNotEquals_ReturnFalse()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualCountry = weather.sys.Country;
            string expectedCountry = "AU";
            bool comparisonResult = (actualCountry != expectedCountry);

            //Assert
            Assert.IsFalse(comparisonResult);

        }

        #endregion

    }
}
