namespace MvcMovie_V1._3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reviews = c.String(),
                        StarRate = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieReviews", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieReviews", new[] { "MovieId" });
            DropTable("dbo.MovieReviews");
        }
    }
}
