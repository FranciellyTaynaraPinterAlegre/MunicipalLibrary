namespace MunicipalLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attbanco : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rents", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Rents", new[] { "Client_Id" });
            RenameColumn(table: "dbo.Rents", name: "Client_Id", newName: "ClientId");
            AlterColumn("dbo.Rents", "ClientId", c => c.Long(nullable: false));
            CreateIndex("dbo.Rents", "ClientId");
            AddForeignKey("dbo.Rents", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "ClientId", "dbo.Clients");
            DropIndex("dbo.Rents", new[] { "ClientId" });
            AlterColumn("dbo.Rents", "ClientId", c => c.Long());
            RenameColumn(table: "dbo.Rents", name: "ClientId", newName: "Client_Id");
            CreateIndex("dbo.Rents", "Client_Id");
            AddForeignKey("dbo.Rents", "Client_Id", "dbo.Clients", "Id");
        }
    }
}
