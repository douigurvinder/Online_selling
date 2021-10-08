using Microsoft.EntityFrameworkCore;
using Online_selling.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_selling.Server
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class1>().HasKey(x => new { x.ID });
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Class1> Class1Set { get; set; }

    }
}
