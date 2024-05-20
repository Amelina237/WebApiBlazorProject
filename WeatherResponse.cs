using Models;

namespace Blazor
{
    public class WeatherResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public MainWeather Weather { get; set; }
    }
}
