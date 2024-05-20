using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Blazor.Data;
using Blazor.Interface;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeather _IWeather;

        public WeatherController(IWeather iWeather)
        {
            _IWeather = iWeather;
        }

        //get data form display and display the list
        [HttpGet]

        public ActionResult<List<MainWeather>> GetWeatherList()
        {
            var weathers = _IWeather.GetWeatherList();

            return Ok(weathers);
        }

        [HttpPost]
        public IActionResult Post(MainWeather weather)
        {
            var response = _IWeather.AddWeather(weather);
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IWeather.DeleteWeather(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetWeather(int id)
        {
            MainWeather weather = _IWeather.getWeatherData(id);
            if (weather != null)
            {
                return Ok(weather);
            }
            return NotFound();
        }


        [HttpPut("{id}")]
        public IActionResult Update(MainWeather weather)
        {
            _IWeather.UpdateWeatherDetails(weather);
            return Ok();
        }


        [HttpGet("{longitude}/{latitude}")]
        public IActionResult GetForecast(float longitude,float latitude)
        {
            var w = _IWeather.getForecastData(longitude, latitude);
            return Ok(w);
        }



    }


}
