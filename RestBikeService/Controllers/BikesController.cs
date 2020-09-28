using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using BikeUnitTest1;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestBikeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private static List<Bike> bikeList = new List<Bike>()
        {
            new Bike(1, "Green", 10, 250),
            new Bike(2, "Yellow", 7, 100),
            new Bike(3, "Red", 5, 300),
            new Bike(4, "Black", 20, 500)
        };


        // GET: api/<BikesController>
        [HttpGet]
        public IEnumerable<Bike> Get()
        {
            return bikeList;
        }
        //test
        // GET api/<BikesController>/5
        [HttpGet("{id}")]
        public Bike Get(int id)
        {
            return bikeList.Find(bike => bike.Id == id);
        }

        // POST api/<BikesController>
        [HttpPost]
        [Route("{id}")]
        public void Post([FromBody] Bike value)
        {

            bikeList.Add(value);
        }

        // PUT api/<BikesController>/5
        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] Bike value)
        {
            Bike bike = Get(id);
            if (bike != null)
            {
                bike.Id = value.Id;
                bike.Color = value.Color;
                bike.Gear = value.Gear;
                bike.Price = value.Price;

            }

        }

        // DELETE api/<BikesController>/5
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Bike bike = Get(id);
            bikeList.Remove(bike);
        }
    }
}
