namespace SandwichShopMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InventoryName = c.String(),
                        Quantity = c.Int(),
                        Ingredients_ID = c.Int(),
                        Menu_MenuID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ingredients", t => t.Ingredients_ID)
                .ForeignKey("dbo.Menu", t => t.Menu_MenuID)
                .Index(t => t.Ingredients_ID)
                .Index(t => t.Menu_MenuID);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MenuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventory", "Menu_MenuID", "dbo.Menu");
            DropForeignKey("dbo.Inventory", "Ingredients_ID", "dbo.Ingredients");
            DropIndex("dbo.Inventory", new[] { "Menu_MenuID" });
            DropIndex("dbo.Inventory", new[] { "Ingredients_ID" });
            DropTable("dbo.Menu");
            DropTable("dbo.Inventory");
            DropTable("dbo.Ingredients");
        }
    }
}
