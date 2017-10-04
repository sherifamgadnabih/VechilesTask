namespace Vechiles.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vechiles", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vechiles", "Status");
        }
    }
}
