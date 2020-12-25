using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreDemo.Models;

namespace Asp.netCoreDemo.Data
{
    public class AspnetCoreDemoContext : DbContext
    {
        public AspnetCoreDemoContext (DbContextOptions<AspnetCoreDemoContext> options)
            : base(options)
        {
        }

        public DbSet<Asp.netCoreDemo.Models.Video> Video { get; set; }
    }
}
