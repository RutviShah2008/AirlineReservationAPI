using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineReservationAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AirlineReservationAPI.Controllers
{
    [Route("api/[controller]")]
    public class FlightController : Controller
    {
        //connect
        DbModel db;

        public FlightController(DbModel db) 
        {
            this.db = db;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return db.Flights.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Flight Get(int id)
        {
            var flight = db.Flights.SingleOrDefault(f => f.FlightID == id);
            return flight;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
