using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCCore.Models
{
    public class MVCCoreContext : DbContext
    {
        public MVCCoreContext (DbContextOptions<MVCCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCore.Models.Movie> Movie { get; set; }
        public DbSet<MVCCore.Models.Book> Book { get; set; }
    }
}
