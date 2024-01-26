namespace FoodDeliveryDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addOrderStatusToOrderDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "OrderStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetails", "OrderStatus");
        }
    }
}
