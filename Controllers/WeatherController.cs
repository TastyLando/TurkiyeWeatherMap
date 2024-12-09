using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using TürkiyeWeatherMap.Models;

public class WeatherController : Controller
{
    private readonly WeatherService _weatherService;

    //public WeatherController(WeatherService weatherService)
    //{
    //    _weatherService = weatherService;
    //}
   
}
