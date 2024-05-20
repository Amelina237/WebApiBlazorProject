using Microsoft.EntityFrameworkCore;
using Models;
using Blazor.Data;
using Blazor.Interface;
using Microsoft.AspNetCore.Mvc;


namespace Blazor.Services
{
    public class WeatherService : IWeather
    {
        private readonly ApplicationDbContext _context;

        public WeatherService(ApplicationDbContext context)
        {
            _context = context;
        }

        //get all weather details
        public List<MainWeather> GetWeatherList()
        {
            var weathers = _context.weathers.ToList();
            return (weathers);

        }

        public WeatherResponse AddWeather(MainWeather weather)
        {
            var existingWeather = _context.weathers.FirstOrDefault(w => w.latitude == weather.latitude && w.longitude == weather.longitude && w.city == weather.city);
            if (existingWeather != null)
            {
                // Return a response if there duplicate data
                return new WeatherResponse
                {
                    Success = false,
                    Message = "A weather record with the same latitude, longitude, and city already exists.",
                    Weather = existingWeather
                };
            }

            //add new data
            _context.weathers.Add(weather);
            _context.SaveChanges();

            return new WeatherResponse
            {
                Success = true,
                Message = "Weather data added successfully.",
                Weather = weather
            };
        }

        //update
        public void UpdateWeatherDetails(MainWeather weather)
        {
            try
            {
                var existing = _context.weathers.FirstOrDefault(x => x.id == weather.id);
                if (existing != null)
                {
                    existing.latitude = weather.latitude;
                    existing.longitude = weather.longitude;
                    existing.city = weather.city;
                    existing.temperature_C = weather.temperature_C;
                    existing.humidity = weather.humidity;
                    existing.condition = weather.condition;
                    existing.condition_Description = weather.condition_Description;

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating weather details: " + ex.Message);
                throw; 
            }
        }

        //get each weather detail
        public MainWeather getWeatherData(int id)
        {
            var weather = _context.weathers.FirstOrDefault(x => x.id == id);
            return (weather);
        }

        //delete 
        public void DeleteWeather(int id)
        {
            var weather = _context.weathers.FirstOrDefault(x => x.id == id);
            if (weather != null)
            {
                _context.weathers.Remove(weather);
                _context.SaveChanges();
            }
        }

        public WeatherResponse getForecastData(float longitude, float latitude)
        {
            var weather = _context.weathers.Where(x => x.latitude == latitude && x.longitude == longitude).FirstOrDefault();
            if (weather != null)
            {
                // Return a response if there duplicate data
                return new WeatherResponse
                {
                    Success = true,
                    Weather = weather
                };
            }

            return new WeatherResponse
            {
                Success = false,
                Message = "Data Not Found!",
                Weather = weather
            };


        }

    }
}
