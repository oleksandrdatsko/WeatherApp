using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenWeatherAPI.Models;

namespace OpenWeatherAPI.UnitTests.Models.UnitTests
{
    [TestClass]
    public class WeatherModelTests
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
        public void WeatherModel_Scenario_CheckIdProperty_Return()
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
    }
}
