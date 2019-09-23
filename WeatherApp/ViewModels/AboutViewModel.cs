using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.ViewModels
{
    public class AboutViewModel : Screen
    {

        public void CloseBtn()
        {
            TryClose();
        }

        public void OpenUrl()
        {
            Process.Start("https://openweathermap.org");
        }
    }
}
