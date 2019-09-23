using Caliburn.Micro;
using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace WeatherApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
            APIHelper.InitializeClient();
            GetLocationListModel GetLocationList = new GetLocationListModel();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<WeatherViewModel>();
        }
    }
}
