namespace MovieSpree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' Where Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' Where Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' Where Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' Where Id = 4");

            // Better approach
            //Sql(
            //    "UPDATE MembershipTypes set Name = (CASE WHEN Id = 1 THEN 'Pay as You Go' WHEN Id = 2 THEN 'Monthly' WHEN Id = 3 THEN 'Quarterly' WHEN Id = 4 THEN 'Annual' END); ");
        }
        
        public override void Down()
        {
        }
    }
}
