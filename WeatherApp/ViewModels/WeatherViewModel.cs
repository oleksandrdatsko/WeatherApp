using Caliburn.Micro;
using OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WeatherApp.Models;
using WeatherApp.Views;

namespace WeatherApp.ViewModels
{
    public class WeatherViewModel : Screen
    {
        #region Private Variables
        private GetWeatherDataModel GetWeatherData = new GetWeatherDataModel();
        private WeatherModel WeatherData;
        private WeatherDataTransformationModel WeatherDataTransformation = new WeatherDataTransformationModel();

        private DispatcherTimer RefreshTimer = new DispatcherTimer();
        private int RefreshIntervalMinutes = DefaultValuesModel.RefreshInterval;

        private IWindowManager WindowManager = new WindowManager();
        private List<Screen> _windows = new List<Screen>();

        public WeatherViewModel()
        {
            LoadWeatherData();
            SetTimer();
        }

        public void LoadWeatherData()
        {
            Task.Run (() => GetData());
        }

        private async Task GetData()
        {
            WeatherData = await GetWeatherData.LoadWeather();

            Name = WeatherData.Name;
            SysCountry = WeatherData.sys.Country;
            Dt = WeatherData.Dt;
            MainTemp = WeatherData.main.Temp;
            MainTempMax = WeatherData.main.Temp_max;
            MainTempMin = WeatherData.main.Temp_min;
            MainHumidity = WeatherData.main.Humidity;
            WindSpeed = WeatherData.wind.Speed;
            WindDeg = WeatherData.wind.Deg;
            WeatherDescription = WeatherData.weather[0].Description.ToUpper();
            WeatherIcon = WeatherData.weather[0].Icon;
        }

        private void SetTimer()
        {
            RefreshTimer.Stop();
            RefreshTimer.Start();
            RefreshTimer.Interval = TimeSpan.FromMinutes(RefreshIntervalMinutes);
            RefreshTimer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Debug.WriteLine("auto refresh triggered at -> " + System.DateTime.Now.ToLongTimeString());
            LoadWeatherData();
        }

        #endregion

        #region Buttons
        public void RefreshWeatherBtn()
        {
            LoadWeatherData();
            //Debug.WriteLine("Refresh Clicked");
        }

        public void SettingsWeatherBtn()
        {
            WindowManager.ShowDialog(new SettingsViewModel(), null, null);
            LoadWeatherData();
        }

        public void AboutWeatherBtn()
        {
            WindowManager.ShowDialog(new AboutViewModel(), null, null);
        }

        public void CloseWeatherBtn()
        {
            Application.Current.Shutdown();
        }
        #endregion

        #region View Properties
        public string CurrentLocation
        {
            get { return $"{ Name }, { SysCountry }"; }
        }

        public string CurrentDay
        {
            get { return DateTime.Today.DayOfWeek.ToString(); }
        }

        public string LastRefreshTimeStamp
        {
            get { return WeatherDataTransformation.GetFullDateFromUnix(Dt).ToString(); }
        }

        public string CurrentDate
        {
            get { return string.Format("{0:MMM, dd}", DateTime.Today); }
        }

        public string CurrentTemp
        {
            get { return WeatherDataTransformation.FormatTemperatureCelsicus(MainTemp); }
        }

        public string TempHighVal
        {
            get { return WeatherDataTransformation.FormatTemperatureCelsicus(MainTempMax); }
        }

        public string TempLowVal
        {
            get { return WeatherDataTransformation.FormatTemperatureCelsicus(MainTempMin); }
        }

        public string CurrentHumidityVal
        {
            get { return WeatherDataTransformation.FormatHumidity(MainHumidity); }
        }

        public string CurrentWindVal
        {
            get { return WeatherDataTransformation.FormatWindSpeedMetric(WindSpeed); }
        }

        public string CurrentWindDirectionVal
        {
            get { return WeatherDataTransformation.GetWindCompassDirection(WindDeg); }
        }

        public string CurrentWeatherName
        {
            get { return $"{ WeatherDescription }"; }
        }

        public ImageSource CurrentWeatherImg
        {
            get { return new BitmapImage(new Uri(WeatherDataTransformation.GetImageUrl(WeatherIcon),UriKind.Absolute)); }
        }

        #endregion

        #region Weather Properties from WeatherModel
        private string _weatherDescription;
        private string _weatherIcon;
        private double _mainTemp;
        private double _mainPressure;
        private double _mainHumidity;
        private double _mainTempMax;
        private double _mainTempMin;
        private double _windSpeed;
        private double _windDeg;
        private string _sysCountry;
        private int _dt;
        private int _id;
        private string _name;

        public string WeatherDescription
        {
            get { return _weatherDescription; }
            set
            {
                _weatherDescription = value;
                NotifyOfPropertyChange(() => CurrentWeatherName);
            }
        }

        public string WeatherIcon
        {
            get { return _weatherIcon; }
            set
            {
                _weatherIcon = value;
                NotifyOfPropertyChange(() => CurrentWeatherImg);
            }
        }

        public double MainTemp
        {
            get { return _mainTemp; }
            set
            {
                _mainTemp = value;
                NotifyOfPropertyChange(() => CurrentTemp);
            }
        }

        public double MainPressure
        {
            get { return _mainPressure; }
            set { _mainPressure = value; }
        }

        public double MainHumidity
        {
            get { return _mainHumidity; }
            set
            {
                _mainHumidity = value;
                NotifyOfPropertyChange(() => CurrentHumidityVal);
            }
        }

        public double MainTempMax
        {
            get { return _mainTempMax; }
            set
            {
                _mainTempMax = value;
                NotifyOfPropertyChange(() => TempHighVal);
            }
        }

        public double MainTempMin
        {
            get { return _mainTempMin; }
            set
            {
                _mainTempMin = value;
                NotifyOfPropertyChange(() => TempLowVal);
            }
        }

        public double WindSpeed
        {
            get { return _windSpeed; }
            set
            {
                _windSpeed = value;
                NotifyOfPropertyChange(() => CurrentWindVal);
            }
        }

        public double WindDeg
        {
            get { return _windDeg; }
            set
            {
                _windDeg = value;
                NotifyOfPropertyChange(() => CurrentWindDirectionVal);
            }
        }

        public string SysCountry
        {
            get { return _sysCountry; }
            set { _sysCountry = value; NotifyOfPropertyChange(() => CurrentLocation); }
        }

        public int Dt
        {
            get { return _dt; }
            set
            {
                _dt = value;
                NotifyOfPropertyChange(() => CurrentDay);
                NotifyOfPropertyChange(() => LastRefreshTimeStamp);
                NotifyOfPropertyChange(() => CurrentDate);
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyOfPropertyChange(() => CurrentLocation); }
        }

        #endregion


    }
}
