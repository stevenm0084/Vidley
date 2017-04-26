namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesAndGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            
            //Sql("INSERT INTO Movies (Id, Name, GenreName, ReleaseDate, DateAdded, NumberInStock) VALUES (1, Hangover, Comedy, )");

        }
        
        public override void Down()
        {
        }
    }
}
