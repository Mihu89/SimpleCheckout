namespace SimpleCheckout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProducTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mobiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZoomUrl = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MobileName = c.String(),
                        Url = c.String(),
                        Feature = c.String(),
                        Model = c.String(),
                        Color = c.String(),
                        SimType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductDetailId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductDetails", t => t.ProductDetailId, cascadeDelete: true)
                .Index(t => t.ProductDetailId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductDetailId", "dbo.ProductDetails");
            DropIndex("dbo.Products", new[] { "ProductDetailId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductDetails");
            DropTable("dbo.Mobiles");
        }
    }
}
