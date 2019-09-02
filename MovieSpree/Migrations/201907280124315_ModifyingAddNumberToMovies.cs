namespace MovieSpree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyingAddNumberToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
