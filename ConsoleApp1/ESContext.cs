using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ESContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Computer>()
                .Map(map =>
                 {
                     map.Properties(prop => new
                     {
                         prop.CoolingTyoe,
                         prop.Description
                     });
                     map.ToTable("TextFields");

                 })
                .Map(map =>
                 {
                     map.Properties(prop => new
                     {
                         prop.Price,
                         prop.Weight

                     });
                     map.ToTable("NumberFields");
                 });
        }
    }
}
