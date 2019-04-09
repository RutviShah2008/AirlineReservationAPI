using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineReservationAPI.Models
{
    public class Flight
    {
        public int FlightID { get; set; }

        
        public DateTime? FlightDate { get; set; }
        
        public int? FlightJetID { get; set; }

            
        public string FlightSource { get; set; }

 
        public string FlightDestination { get; set; }


        public string FlightTime { get; set; }
        
    }
}
