using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechiles.Data.Mappings;
using Vechiles.Models;

namespace Vechiles.Data.Context
{
    public class VechilesDataContext : DbContext
    {
        public VechilesDataContext() : base("dataContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new VechileMap());
            modelBuilder.Configurations.Add(new CustomerMap());
        }
        public DbSet<Vechile> Vechiles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void Dispose(bool disposing)
        {
            this.SaveChanges();
            base.Dispose(disposing);
        }
    }
}
