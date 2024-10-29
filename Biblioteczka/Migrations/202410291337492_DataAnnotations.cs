namespace Biblioteczka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Name", c => c.String(maxLength: 60));
            AlterColumn("dbo.Books", "Author", c => c.String(maxLength: 60));
            AlterColumn("dbo.Books", "PublishingHouse", c => c.String(maxLength: 60));
            AlterColumn("dbo.Books", "BookBinding", c => c.String(maxLength: 6));
            AlterColumn("dbo.Books", "ISBN", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "ISBN", c => c.String());
            AlterColumn("dbo.Books", "BookBinding", c => c.String());
            AlterColumn("dbo.Books", "PublishingHouse", c => c.String());
            AlterColumn("dbo.Books", "Author", c => c.String());
            AlterColumn("dbo.Books", "Name", c => c.String());
        }
    }
}
