using OpenWeatherAPI.API;
using OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class GetWeatherDataModel
    {

        public async Task<WeatherModel> LoadWeather()
        {
            string url = "";
            if( DefaultValuesModel.APIKey != "")
            {
                url = $"http://api.openweathermap.org/data/2.5/weather?id={ DefaultValuesModel.CityID }&appid={ DefaultValuesModel.APIKey }&units={ DefaultValuesModel.Units }";
            }
            else
            {
                url = "https://samples.openweathermap.org/data/2.5/weather?id=2172797&appid=b6907d289e10d714a6e88b30761fae22";
            }

            WeatherModel response = await APIProcessor<WeatherModel>.APICall(url);

            return response;
        }

    }


}
