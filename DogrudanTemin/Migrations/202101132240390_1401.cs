namespace DogrudanTemin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1401 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ANTET",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SATIR1 = c.String(maxLength: 100),
                        SATIR2 = c.String(maxLength: 100),
                        SATIR3 = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KANITLAYICI",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KanitlayiciBelgeAdi = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KISILER",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        kisiAdi = c.String(maxLength: 50),
                        unvani = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KURUM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        kurumadi = c.String(maxLength: 50),
                        parola = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MALZEME",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MalzemeCinsi = c.String(maxLength: 50),
                        MalzemeOzellikleri = c.String(maxLength: 255),
                        Miktari = c.Int(),
                        OlcuBirimi = c.String(maxLength: 50),
                        KdvOrani = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MALZEME");
            DropTable("dbo.KURUM");
            DropTable("dbo.KISILER");
            DropTable("dbo.KANITLAYICI");
            DropTable("dbo.ANTET");
        }
    }
}
