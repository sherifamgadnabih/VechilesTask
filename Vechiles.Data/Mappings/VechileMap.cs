using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vechiles.Models;

namespace Vechiles.Data.Mappings
{
    public class VechileMap : EntityTypeConfiguration<Vechile>
    {
        public VechileMap()
        {
            this.ToTable("Vechiles");
            this.HasKey(s => s.Id);
            this.Property(s => s.VIN).IsRequired();
            this.Property(s => s.RegNr).IsRequired();
            this.Property(s => s.CustomerId).IsRequired();
            this.HasRequired(s => s.Customer).WithMany().HasForeignKey(s => s.CustomerId);
        }
    }
}
