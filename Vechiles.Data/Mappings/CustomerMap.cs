using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechiles.Models;

namespace Vechiles.Data.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.ToTable("Customers");
            this.HasKey(s => s.Id);
            this.Property(s => s.Name).HasMaxLength(200).IsRequired();
            this.Property(s => s.Address).HasMaxLength(500).IsRequired();
        }
    }
}
