namespace Biblioteczka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "OwnerID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "OwnerID", c => c.Int(nullable: false));
        }
    }
}
