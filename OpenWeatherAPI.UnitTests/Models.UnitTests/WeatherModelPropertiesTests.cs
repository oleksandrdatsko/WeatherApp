using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenWeatherAPI.Models;

namespace OpenWeatherAPI.UnitTests.Models.UnitTests
{
    [TestClass]
    public class WeatherModelPropertiesTests
    {

        private string jsonWeatherResponse = "";

        private void ReadWeatherResponseJson()
        {
            using ( StreamReader streamReader = new StreamReader(@"D:\Visual Studio Projects\MVVM_WPF\OpenWeatherAPI.UnitTests\Resources\SampleWeatherResponse.json") )
            {
                jsonWeatherResponse = streamReader.ReadToEnd();
            }
        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckWeather_DescriptionProperty_ReturnScattered_Clouds()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualWeatherDescription = weather.weather[0].Description;
            string expectedWeatherDescription = "scattered clouds";

            //Assert
            Assert.AreEqual(actualWeatherDescription, expectedWeatherDescription);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckWeather_IconProperty_Return03n()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualWeatherIcon = weather.weather[0].Icon;
            string expectedWeatherIcon = "03n";

            //Assert
            Assert.AreEqual(actualWeatherIcon, expectedWeatherIcon);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckMain_TempProperty_Return300_15()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            double actualMainTemp = weather.main.Temp;
            double expectedMainTemp = 300.15;

            //Assert
            Assert.AreEqual(actualMainTemp, expectedMainTemp);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckMain_PressureProperty_Return1007()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            double actualMainPressure = weather.main.Pressure;
            double expectedMainPressure = 1007;

            //Assert
            Assert.AreEqual(actualMainPressure, expectedMainPressure);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckMain_HumidityProperty_Return74()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            double actualMainHumidity = weather.main.Humidity;
            double expectedMainHumidity = 74;

            //Assert
            Assert.AreEqual(actualMainHumidity, expectedMainHumidity);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckMain_Temp_minProperty_Return300_15()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            double actualMainTemp_min = weather.main.Temp_min;
            double expectedMainTemp_min = 300.15;

            //Assert
            Assert.AreEqual(actualMainTemp_min, expectedMainTemp_min);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckMain_Temp_maxProperty_Return300_15()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            double actualMainTemp_max = weather.main.Temp_max;
            double expectedMainTemp_max = 300.15;

            //Assert
            Assert.AreEqual(actualMainTemp_max, expectedMainTemp_max);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckWind_SpeedProperty_Return3_6()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            double actualWindSpeed = weather.wind.Speed;
            double expectedWindSpeed = 3.6;

            //Assert
            Assert.AreEqual(actualWindSpeed, expectedWindSpeed);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckWind_DegProperty_Return160()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            double actualWindDeg = weather.wind.Deg;
            double expectedWindDeg = 160;

            //Assert
            Assert.AreEqual(actualWindDeg, expectedWindDeg);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckSys_CountryProperty_ReturnAU()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualCountry = weather.sys.Country;
            string expectedCountry = "AU";

            //Assert
            Assert.AreEqual(actualCountry, expectedCountry);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckDtProperty_Return1485790200()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            int actualDt = weather.Dt;
            int expectedDt = 1485790200;

            //Assert
            Assert.AreEqual(actualDt, expectedDt);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckIdProperty_Return2172797()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            int actualId = weather.Id;
            int expectedId = 2172797;

            //Assert
            Assert.AreEqual(actualId, expectedId);

        }

        [TestMethod]
        public void WeatherModel_Scenario_CheckNameProperty_ReturnCairns()
        {
            //Arrange
            ReadWeatherResponseJson();

            //Act
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonWeatherResponse);
            string actualName = weather.Name;
            string expectedName = "Cairns";

            //Assert
            Assert.AreEqual(actualName, expectedName);

        }

    }
}
