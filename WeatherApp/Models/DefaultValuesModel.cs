using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public static class DefaultValuesModel
    {
        private static int _cityID = Properties.Settings.Default.CityId;
        private static string _cityName = Properties.Settings.Default.CityName;
        private static string _APIKey = Properties.Settings.Default.APIKey;
        private static string _units = Properties.Settings.Default.Units;
        private static int _refreshInterval = Properties.Settings.Default.RefreshFrequencyMinutes;
        private static string _Country = Properties.Settings.Default.Country;

        public static int CityID
        {
            get { return _cityID; }
            set { _cityID = value; }
        }

        public static string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        public static string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }


        public static string APIKey
        {
            get { return _APIKey; }
            set { _APIKey = value; }
        }

        public static string Units
        {
            get { return _units; }
            set { _units = value; }
        }

        public static int RefreshInterval
        {
            get { return _refreshInterval; }
            set { _refreshInterval = value; }
        }



    }
}
