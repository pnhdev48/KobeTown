namespace KobeTown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderDetail : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.tb_OrderDetail");
            AddColumn("dbo.tb_OrderDetail", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.tb_OrderDetail", "Quantity", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.tb_OrderDetail", "Id");
            DropColumn("dbo.tb_OrderDetail", "Quatity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_OrderDetail", "Quatity", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.tb_OrderDetail");
            DropColumn("dbo.tb_OrderDetail", "Quantity");
            DropColumn("dbo.tb_OrderDetail", "Id");
            AddPrimaryKey("dbo.tb_OrderDetail", new[] { "OrderId", "ProductId" });
        }
    }
}
