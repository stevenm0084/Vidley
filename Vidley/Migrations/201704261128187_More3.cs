namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class More3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 2, 1/1/1989, 26/04/2017, 5)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 2, 1/1/1984, 26/04/2017, 2)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 3, 1/1/1995, 26/04/2017, 2)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hangover', 1, 1/1/2005, 02/03/2015, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
