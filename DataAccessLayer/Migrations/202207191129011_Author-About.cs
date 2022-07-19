namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorAbout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorAbout", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "AuthorAbout");
        }
    }
}
