using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

public class WeatherController : Controller
{
    private readonly WeatherService _weatherService;

    public WeatherController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCityWeather(string city)
    {
        var weatherJson = await _weatherService.GetWeatherAsync(city);
        var weatherData = JObject.Parse(weatherJson);
        var temperature = weatherData["current"]["temp_c"];
        var condition = weatherData["current"]["condition"]["text"];

        return Json(new { temp_c = temperature, condition });
    }
}
