namespace Vechiles.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vechiles.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vechiles.Data.Context.VechilesDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vechiles.Data.Context.VechilesDataContext context)
        {

            context.Customers.AddOrUpdate(s => s.Id, new Customer() { Id = 1, Name = "Kalles Grustransporter AB", Address = "Cementvägen 8, 111 11 Södertälje" },
                new Customer { Id = 2, Name = "Johans Bulk AB", Address = "Balkvägen 12, 222 22 Stockholm" },
                new Customer() { Id = 3, Name = "Haralds Värdetransporter AB", Address = "Budgetvägen 1, 333 33 Uppsala" });

            context.Vechiles.AddOrUpdate(s => s.Id, new Vechile() { Id = 1, CustomerId = 1, VIN = "YS2R4X20005399401", RegNr = "ABC123" },
                new Vechile() { Id = 2, CustomerId = 1, VIN = "VLUR4X20009093588", RegNr = "DEF456" },
                new Vechile() { Id = 3, CustomerId = 1, VIN = "VLUR4X20009048066", RegNr = "GHI789" },
                new Vechile() { Id = 4, CustomerId = 2, VIN = "YS2R4X20005388011", RegNr = "JKL012" },
                new Vechile() { Id = 5, CustomerId = 2, VIN = "YS2R4X20005387949", RegNr = "MNO345" },
                new Vechile() { Id = 6, CustomerId = 3, VIN = "YS2R4X20005387765", RegNr = "PQR678" },
                new Vechile() { Id = 7, CustomerId = 3, VIN = "YS2R4X20005387055", RegNr = "STU901" }
                );
        }
    }
}
