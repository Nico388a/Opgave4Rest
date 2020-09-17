using System;
using System.Collections.Generic;
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

        // GET api/<BikesController>/5
        [HttpGet("{id}")]
        public Bike Get(int id)
        {
            return bikeList.Find(bike=> bike.Id == id);
        }

        // POST api/<BikesController>
        [HttpPost]
        [Route("{id}")]
        public void Post([FromBody] Bike value)
        {
            

        }

        // PUT api/<BikesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
            
        }

        // DELETE api/<BikesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
