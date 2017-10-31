namespace MunicipalLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulableBooks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Books (Title,Subtitle,Volume,Author_Id,Language,Category,Location) VALUES ('House Of Night','Maked',1,'Kristin Cast and PC Kast','Portugues-BR','Ficção Americana','A38')");
        }
        
        public override void Down()
        {
        }
    }
}
