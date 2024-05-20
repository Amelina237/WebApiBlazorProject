using Models;
using static Blazor.Services.WeatherService;

namespace Blazor.Interface
{
    public interface IWeather
    {
        public List<MainWeather> GetWeatherList();
        public WeatherResponse AddWeather(MainWeather weather);
        public void UpdateWeatherDetails(MainWeather weather);
        public MainWeather getWeatherData(int id);
        public void DeleteWeather(int id);
        public WeatherResponse getForecastData(float longitude, float latitude);
    }
}
