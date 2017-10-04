namespace Vechiles.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Address = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vechiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VIN = c.String(nullable: false),
                        RegNr = c.String(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vechiles", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Vechiles", new[] { "CustomerId" });
            DropTable("dbo.Vechiles");
            DropTable("dbo.Customers");
        }
    }
}
