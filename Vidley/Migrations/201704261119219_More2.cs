namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class More2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, 1/1/1999, 26/04/2017, 3)");

        }
        
        public override void Down()
        {
        }
    }
}
