namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE MembershipTypes (Id, Name, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0) ");
            Sql("UPDATE MembershipTypes (Id, Name, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10) ");
             Sql("UPDATE MembershipTypes (Id, Name, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15) ");
            Sql("UPDATE MembershipTypes (Id, Name, DurationInMonths, DiscountRate) VALUES (4, 300, 4, 20) ");
        }
        
        public override void Down()
        {
        }
    }
}
