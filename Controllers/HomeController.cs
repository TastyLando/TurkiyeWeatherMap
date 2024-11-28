using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using TürkiyeWeatherMap.Models;

namespace TürkiyeWeatherMap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Map()
        {

            string jsonData = @"
        {
            'location': {
                'name': 'Ankara',
                'region': 'Ankara',
                'country': 'Turkey',
                'lat': 39.927,
                'lon': 32.864,
                'tz_id': 'Europe/Istanbul',
                'localtime_epoch': 1732622634,
                'localtime': '2024-11-26 15:03'
            },
            'current': {
                'last_updated_epoch': 1732622400,
                'last_updated': '2024-11-26 15:00',
                'temp_c': 2.1,
                'temp_f': 35.8,
                'is_day': 1,
                'condition': {
                    'text': 'Partly cloudy',
                    'icon': '//cdn.weatherapi.com/weather/64x64/day/116.png',
                    'code': 1003
                },
                'wind_mph': 4.5,
                'wind_kph': 7.2,
                'wind_degree': 266,
                'wind_dir': 'W',
                'pressure_mb': 1019.0,
                'pressure_in': 30.09,
                'precip_mm': 0.01,
                'precip_in': 0.0,
                'humidity': 87,
                'cloud': 75,
                'feelslike_c': 0.0,
                'feelslike_f': 31.9,
                'windchill_c': -1.5,
                'windchill_f': 29.3,
                'heatindex_c': 0.9,
                'heatindex_f': 33.5,
                'dewpoint_c': -1.6,
                'dewpoint_f': 29.2,
                'vis_km': 10.0,
                'vis_miles': 6.0,
                'uv': 0.7,
                'gust_mph': 5.1,
                'gust_kph': 8.3
            }
        }";

            // JSON verisini modele dönüştür
            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonData);

            return View(weatherData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
