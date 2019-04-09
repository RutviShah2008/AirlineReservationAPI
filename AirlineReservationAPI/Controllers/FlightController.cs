
using System.Collections.Generic;
using System.Linq;
using AirlineReservationAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public ActionResult Get(int id)
        {
            var flight = db.Flights.SingleOrDefault(f => f.FlightID == id);
            if(flight == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(flight);
            }            
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                db.Flights.Add(flight);
                db.SaveChanges();
                return CreatedAtAction("Post", new { id = flight.FlightID }, flight);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                db.Entry(flight).State = EntityState.Modified;
                db.SaveChanges();
                return AcceptedAtAction("Put", new { id = flight.FlightID }, flight);
            }
        }

        [HttpPatch("{id}")]
        public ActionResult Patch([FromBody] Flight flight)
        {
            var flights = db.Flights.FirstOrDefault(f => f.FlightID == flight.FlightID);
            if (flights == null)
                return NotFound();
            else
            {
                db.Flights.Add(flights);
                db.SaveChanges();
                return Ok();

            }
            
        }
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var flight = db.Flights.SingleOrDefault(f => f.FlightID == id);
            if (flight == null)
            {
                return NotFound();
            }
            else
            {
                db.Flights.Remove(flight);
                db.SaveChanges();
                return Ok();
            }
        }

        
    }
}
