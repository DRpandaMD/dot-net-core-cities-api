using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
           return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var CityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == id);
            if ( CityToReturn == null)
            {
                return NotFound();
            }

            return Ok(CityToReturn);
        }
    }
}