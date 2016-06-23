namespace ECom.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(),
                        HouseNo = c.String(),
                        AddressLine2 = c.String(),
                        PinCode = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        IsCurrentAddress = c.Boolean(nullable: false),
                        CustomerID_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Customers", t => t.CustomerID_CustomerID)
                .Index(t => t.CustomerID_CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        MobileNo = c.String(),
                        EmailId = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.PriceTags",
                c => new
                    {
                        PriceTagId = c.Int(nullable: false, identity: true),
                        UnitPrice = c.Double(nullable: false),
                        PriceEnteredDate = c.DateTime(nullable: false),
                        IsCurrentRate = c.Boolean(nullable: false),
                        ProductId_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.PriceTagId)
                .ForeignKey("dbo.Products", t => t.ProductId_ProductId)
                .Index(t => t.ProductId_ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        PrductName = c.String(),
                        Specifications = c.String(),
                        TechnicalSpecs = c.String(),
                        CategoryId_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId_CategoryID)
                .Index(t => t.CategoryId_CategoryID);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImageUniqueId = c.String(),
                        IsActiveImage = c.Boolean(nullable: false),
                        OrderOfImage = c.Int(nullable: false),
                        ProductId_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Products", t => t.ProductId_ProductId)
                .Index(t => t.ProductId_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductImages", "ProductId_ProductId", "dbo.Products");
            DropForeignKey("dbo.PriceTags", "ProductId_ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId_CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Addresses", "CustomerID_CustomerID", "dbo.Customers");
            DropIndex("dbo.ProductImages", new[] { "ProductId_ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId_CategoryID" });
            DropIndex("dbo.PriceTags", new[] { "ProductId_ProductId" });
            DropIndex("dbo.Addresses", new[] { "CustomerID_CustomerID" });
            DropTable("dbo.ProductImages");
            DropTable("dbo.Products");
            DropTable("dbo.PriceTags");
            DropTable("dbo.Categories");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
