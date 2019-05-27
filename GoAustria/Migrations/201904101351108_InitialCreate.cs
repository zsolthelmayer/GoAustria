namespace GoAustria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sequence = c.Int(nullable: false),
                        Title = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        Price = c.String(),
                        OrdFirstname = c.String(),
                        OrdSurname = c.String(),
                        OrdEmail = c.String(),
                        OrdPhone = c.String(),
                        TransName = c.String(),
                        TransPostalCode = c.String(),
                        TransCity = c.String(),
                        TransAddress = c.String(),
                        TransCountry = c.String(),
                        TransPhone = c.String(),
                        InvName = c.String(),
                        InvPostalCode = c.String(),
                        InvCity = c.String(),
                        InvAddress = c.String(),
                        InvCountry = c.String(),
                        InvPhone = c.String(),
                        InvTaxNum = c.String(),
                        PaymentMethod = c.Int(nullable: false),
                        PostalFee = c.String(),
                        Comment = c.String(),
                        OrderDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Links");
        }
    }
}
