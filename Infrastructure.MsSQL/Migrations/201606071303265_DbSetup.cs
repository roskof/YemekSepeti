namespace Infrastructure.MsSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        ShopId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meals", "ShopId", "dbo.Shops");
            DropIndex("dbo.Meals", new[] { "ShopId" });
            DropTable("dbo.Shops");
            DropTable("dbo.Meals");
        }
    }
}
