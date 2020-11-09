using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SVAPI.Models;

namespace SVAPI.Data
{
    public class SVAPIContext : DbContext
    {
        public SVAPIContext (DbContextOptions<SVAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SVAPI.Models.User> Users { get; set; }
    }
}
