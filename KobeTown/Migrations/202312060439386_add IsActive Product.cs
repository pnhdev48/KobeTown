namespace KobeTown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsActiveProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "Alias", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Product", "isActive", c => c.Boolean(nullable: false));
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String(maxLength: 50));
            AlterColumn("dbo.tb_Product", "Image", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Product", "Image", c => c.String());
            AlterColumn("dbo.tb_Product", "ProductCode", c => c.String());
            DropColumn("dbo.tb_Product", "isActive");
            DropColumn("dbo.tb_Product", "Alias");
        }
    }
}
