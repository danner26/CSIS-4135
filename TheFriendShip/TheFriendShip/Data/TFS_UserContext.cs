using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

{
    public class TFS_UserContext : DbContext
    {
        public TFS_UserContext(DbContextOptions<TFS_UserContext> options)
            : base(options)
        {
        }
    }
}
