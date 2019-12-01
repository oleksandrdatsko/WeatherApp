using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OpenWeatherAPI.UnitTests
{
    [TestClass]
    public class APIHelperTests
    {
        [TestMethod]
        public void APIClient_Scenario_Initialize_ReturnsTrue()
        {
            // Arrange
            APIHelper.InitializeClient();
            // Act

            // Asert
            Assert.IsNotNull(APIHelper.APIClient);
            
        }

        [TestMethod]
        public async Task APIClient_Scenario_GetResponse_ReturnSuccess()
        {
            APIHelper.InitializeClient();

            string url = "https://samples.openweathermap.org/data/2.5/weather?id=2172797&appid=b6907d289e10d714a6e88b30761fae22";
            HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url);
            HttpStatusCode actualResponseCode = response.StatusCode;
            HttpStatusCode expectedResponseCode = HttpStatusCode.OK;
            Task.WaitAll();

            Assert.AreEqual(actualResponseCode, expectedResponseCode);

        }
    }
}
