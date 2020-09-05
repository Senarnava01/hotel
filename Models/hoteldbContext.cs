using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class hoteldbContext:DbContext
    {
        public hoteldbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Boarder> Boarders { get; set; }
        public DbSet<room> booking { get; set; }
        public DbSet<booking> bookings { get; set; }
    }
}
