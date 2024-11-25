using System.Net.Http;
using System.Threading.Tasks;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "8161e4ef4d594891969152916242511";

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetWeatherAsync(string city)
    {
        string url = $"https://api.weatherapi.com/v1/current.json?key={_apiKey}&q={city}&aqi=no";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
