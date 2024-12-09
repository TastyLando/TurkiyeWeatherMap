using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        
        public async Task<IActionResult> Map(string city)
        {
            string apiKey = "8161e4ef4d594891969152916242511";
            string apiUrl = $"http://api.weatherapi.com/v1/current.json?key=8161e4ef4d594891969152916242511&q=Ankara&aqi=yes";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl); 
                response.EnsureSuccessStatusCode(); 

                var data = JObject.Parse(await response.Content.ReadAsStringAsync());

                var weatherInfo = new WeatherInfo
                {
                    City = data["location"]["name"].ToString(),
                    Condition = data["current"]["condition"]["text"].ToString(),
                    Temperature = data["current"]["temp_c"].ToString(),
                    Icon = data["current"]["condition"]["icon"].ToString()
                };

                return View(weatherInfo);
            }
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
