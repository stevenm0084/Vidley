namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.Movies", new[] { "GenreId_Id" });
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Int());
            AlterColumn("dbo.Movies", "GenreId_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id");
            CreateIndex("dbo.Movies", "GenreId_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres");
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId_Id" });
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            AlterColumn("dbo.Movies", "GenreId_Id", c => c.Int());
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenreId_Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
