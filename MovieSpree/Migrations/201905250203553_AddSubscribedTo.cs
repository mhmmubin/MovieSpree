namespace MovieSpree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubscribedTo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedtonewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedtonewsLetter");
        }
    }
}
