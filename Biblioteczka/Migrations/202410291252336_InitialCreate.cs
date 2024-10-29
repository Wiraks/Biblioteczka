namespace Biblioteczka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        PublishingHouse = c.String(),
                        ReleaseDate = c.Int(nullable: false),
                        NumberOfPages = c.Int(nullable: false),
                        BookBinding = c.String(),
                        ISBN = c.String(),
                        OwnerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
