using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCars.Models
{
    public class MvcCarsContext : DbContext
    {
        public MvcCarsContext (DbContextOptions<MvcCarsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCars.Models.Car> Car { get; set; }
    }
}
