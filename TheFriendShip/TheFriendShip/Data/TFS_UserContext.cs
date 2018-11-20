using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFriendShip.Data
{
    public class TFS_UserContext : IdentityDbContext
    {
        public TFS_UserContext(DbContextOptions<TFS_UserContext> options) : base(options)
        {
        }

    public DbSet<Models.Users> Review { get; set; }
}
}
