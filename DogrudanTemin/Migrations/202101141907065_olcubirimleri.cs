namespace DogrudanTemin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class olcubirimleri : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OlcuBirimleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OlcuBirimAdi = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OlcuBirimleri");
        }
    }
}
