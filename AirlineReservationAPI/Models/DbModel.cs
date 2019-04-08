using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineReservationAPI.Models
{
    public class DbModel : DbContext
    {
        public DbModel(DbContextOptions<DbModel> options) : base(options)
        {

        }

        public DbSet<Flight> Flights { get; set; }





    }
}
