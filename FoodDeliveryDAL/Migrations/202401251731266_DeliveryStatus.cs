namespace FoodDeliveryDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeliveryStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryStatus",
                c => new
                    {
                        DeliveryStatusId = c.Int(nullable: false, identity: true),
                        StatusName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DeliveryStatusId)
                .Index(t => t.StatusName, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.DeliveryStatus", new[] { "StatusName" });
            DropTable("dbo.DeliveryStatus");
        }
    }
}
