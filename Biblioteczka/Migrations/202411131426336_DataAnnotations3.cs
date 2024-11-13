namespace Biblioteczka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "OwnerMail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "OwnerMail");
        }
    }
}
