namespace KobeTown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droptablecategory : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.tb_Category");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tb_Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Position = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
