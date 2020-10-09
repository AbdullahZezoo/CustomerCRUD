namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.customers", "Done", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.customers", "Done");
        }
    }
}
