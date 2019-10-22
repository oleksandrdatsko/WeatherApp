using Caliburn.Micro;
using OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class SettingsViewModel : Screen
    {

        private LocationModel _myLocation;
        private string _myFullLocation;
        private bool _metricUnits = false;
        private bool _imperialUnits = false;
        private int _refreshInterval;
        private string _APIKey;
        private BindableCollection<int> _refreshIntervalsList;

        public SettingsViewModel()
        {
            //LoadLocationList();
            RefreshIntervalsList = new RefreshIntervalModel().RefreshIntervals;
            GetDefaultSettings();

        }

        public void GetDefaultSettings()
        {
            LocationModel MyLoc = new LocationModel();
            MyLoc.Id = DefaultValuesModel.CityID;
            MyLoc.Name = DefaultValuesModel.CityName;
            MyLoc.Country = DefaultValuesModel.Country;
            MyLocation = MyLoc;
            MyFullLocation = MyLocation.FullLocation;
            RefreshInterval = DefaultValuesModel.RefreshInterval;
            APIKey = DefaultValuesModel.APIKey;
            GetDefaultUnits(DefaultValuesModel.Units);
        }

        public void SetDefaultSettings()
        {
            DefaultValuesModel.RefreshInterval = RefreshInterval;
            DefaultValuesModel.APIKey = APIKey;
            DefaultValuesModel.Units = SetDefaultUnits();
            if(MyLocation != null)
            {
                DefaultValuesModel.CityID = MyLocation.Id;
                DefaultValuesModel.CityName = MyLocation.Name;
                DefaultValuesModel.Country = MyLocation.Country;
            }

            DefaultValuesModel.SaveDefaultValues();

        }

        public void GetDefaultUnits(string units)
        {
            if (units == "metric")
            {
                MetricUnits = true;
            }
            else
            {
                ImperialUnits = true;
            }
        }

        public string SetDefaultUnits()
        {
            if (MetricUnits)
            {
                return "metric";
            }
            else
            {
                return "imperial";
            }
        }

        public void SaveAndClose()
        {
            SetDefaultSettings();
            TryClose();
        }

        public void Cancel()
        {
            TryClose();
        }

        public LocationModel MyLocation
        {
            get { return _myLocation; }
            set { _myLocation = value; }
        }

        public string MyFullLocation
        {
            get { return _myFullLocation; }
            set { _myFullLocation = value; }
        }

        public bool MetricUnits
        {
            get { return _metricUnits; }
            set { _metricUnits = value; }
        }

        public bool ImperialUnits
        {
            get { return _imperialUnits; }
            set { _imperialUnits = value; }
        }

        public int RefreshInterval
        {
            get { return _refreshInterval; }
            set { _refreshInterval = value; }
        }

        public BindableCollection<int> RefreshIntervalsList

        {
            get { return _refreshIntervalsList; }
            set { _refreshIntervalsList = value; }
        }

        public string APIKey
        {
            get { return _APIKey; }
            set { _APIKey = value; }
        }

    }
}
