namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class More : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenreName_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_GenreName_Id", newName: "IX_Genre_Id");
            DropColumn("dbo.Movies", "GenreTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreName_Id");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreName_Id");
        }
    }
}
