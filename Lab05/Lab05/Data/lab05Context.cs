using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab05.Models
{
    public class lab05Context : DbContext
    {
        public lab05Context (DbContextOptions<lab05Context> options)
            : base(options)
        {
        }

        public DbSet<lab05.Models.Movie> Movie { get; set; }
    }
}
