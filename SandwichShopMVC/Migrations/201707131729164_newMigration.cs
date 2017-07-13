namespace SandwichShopMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Inventory", newName: "UpdateSales");
            AddColumn("dbo.Menu", "Ingredients", c => c.String());
            AddColumn("dbo.UpdateSales", "Name", c => c.String());
            DropColumn("dbo.UpdateSales", "InventoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UpdateSales", "InventoryName", c => c.String());
            DropColumn("dbo.UpdateSales", "Name");
            DropColumn("dbo.Menu", "Ingredients");
            RenameTable(name: "dbo.UpdateSales", newName: "Inventory");
        }
    }
}
