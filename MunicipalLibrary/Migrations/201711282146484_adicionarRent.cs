namespace MunicipalLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionarRent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RentDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Book_Id = c.Long(),
                        Client_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Rents", "Book_Id", "dbo.Books");
            DropIndex("dbo.Rents", new[] { "Client_Id" });
            DropIndex("dbo.Rents", new[] { "Book_Id" });
            DropTable("dbo.Rents");
        }
    }
}
