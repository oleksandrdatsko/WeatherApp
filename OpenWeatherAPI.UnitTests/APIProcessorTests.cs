using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenWeatherAPI.API;
using System.Threading.Tasks;
using OpenWeatherAPI.Models;
using System.Net.Http;

namespace OpenWeatherAPI.UnitTests
{
    /// <summary>
    /// Summary description for APIProcessorTests
    /// </summary>
    [TestClass]
    public class APIProcessorTests
    {
        [TestMethod]
        public async Task APIProcessor_Scenario_APICall_ReturnsWeatherModel()
        {
            //Arrange
            APIHelper.InitializeClient();

            //Act
            string url = "https://samples.openweathermap.org/data/2.5/weather?id=2172797&appid=b6907d289e10d714a6e88b30761fae22";
            WeatherModel result  = await APIProcessor<WeatherModel>.APICall(url);

            HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url);
            WeatherModel expectedResult = await response.Content.ReadAsAsync<WeatherModel>();

            Task.WaitAll();

            //Assert
            Assert.IsTrue(result == expectedResult);

        }
    }
}
