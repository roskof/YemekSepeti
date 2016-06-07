namespace Infrastructure.MsSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjustTest : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Meals", "Description2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Meals", "Description2", c => c.String());
        }
    }
}
