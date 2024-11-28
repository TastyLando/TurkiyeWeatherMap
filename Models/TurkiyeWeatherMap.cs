using TürkiyeWeatherMap.Controllers;
namespace TürkiyeWeatherMap.Models
{
    public class WeatherCondition
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }

    public class WeatherLocation
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string TzId { get; set; }
        public long LocaltimeEpoch { get; set; }
        public string Localtime { get; set; }
    }

    public class WeatherCurrent
    {
        public string LastUpdated { get; set; }
        public double TempC { get; set; }
        public double TempF { get; set; }
        public bool IsDay { get; set; }
        public WeatherCondition Condition { get; set; }
        public double WindMph { get; set; }
        public double WindKph { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public double PressureMb { get; set; }
        public double PressureIn { get; set; }
        public double PrecipMm { get; set; }
        public double PrecipIn { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public double FeelsLikeC { get; set; }
        public double FeelsLikeF { get; set; }
        public double WindchillC { get; set; }
        public double WindchillF { get; set; }
        public double HeatIndexC { get; set; }
        public double HeatIndexF { get; set; }
        public double DewpointC { get; set; }
        public double DewpointF { get; set; }
        public double VisKm { get; set; }
        public double VisMiles { get; set; }
        public double Uv { get; set; }
        public double GustMph { get; set; }
        public double GustKph { get; set; }
    }

    public class WeatherData
    {
        public WeatherLocation Location { get; set; }
        public WeatherCurrent Current { get; set; }
    }
}
