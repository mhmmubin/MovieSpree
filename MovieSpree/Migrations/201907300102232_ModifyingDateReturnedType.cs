namespace MovieSpree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyingDateReturnedType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
        }
    }
}
