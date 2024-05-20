    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MainWeather
    {
        public int id {  get; set; }

        [Required(ErrorMessage = "Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180 degrees.")]
        public float? longitude { get; set; }

        [Required(ErrorMessage = "Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90 degrees.")]
        public float? latitude { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string city {  get; set; }

        [Required(ErrorMessage = "Temperature is required.")]
        [Range(-90, 90, ErrorMessage = "Temperature must be between -50 and 60 Celcius.")]
        public float? temperature_C { get; set; }

        [Required(ErrorMessage = "Humidity is required.")]
        [Range(0, 100, ErrorMessage = "Humidity must be between 0 and 100%.")]
        public int? humidity { get; set; }
        public string condition { get; set; }
        public string condition_Description { get; set; }

    }
}
