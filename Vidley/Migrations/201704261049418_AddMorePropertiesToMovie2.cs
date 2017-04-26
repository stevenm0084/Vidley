namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMorePropertiesToMovie2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                        GenreName_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreName_Id)
                .Index(t => t.GenreName_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreName_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreName_Id" });
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
