using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab06.Models
{
    public class Lab06Context : DbContext
    {
        public Lab06Context (DbContextOptions<Lab06Context> options)
            : base(options)
        {
        }

        public DbSet<Lab06.Models.Movie> Movie { get; set; }
    }
}
