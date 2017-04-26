namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixBirthdayToBirthdateInCustomer : DbMigration
    {
        public override void Up()
        {
            
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Customers", "Birthday");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime());
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
