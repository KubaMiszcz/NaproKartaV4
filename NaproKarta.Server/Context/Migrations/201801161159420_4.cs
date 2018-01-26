namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Observations", "CommentId", "dbo.Comments");
            DropIndex("dbo.Observations", new[] { "CommentId" });
            CreateTable(
                "dbo.CommentObservations",
                c => new
                    {
                        Comment_Id = c.Int(nullable: false),
                        Observation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Comment_Id, t.Observation_Id })
                .ForeignKey("dbo.Comments", t => t.Comment_Id, cascadeDelete: true)
                .ForeignKey("dbo.Observations", t => t.Observation_Id, cascadeDelete: true)
                .Index(t => t.Comment_Id)
                .Index(t => t.Observation_Id);
            
            DropColumn("dbo.Observations", "CommentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Observations", "CommentId", c => c.Int());
            DropForeignKey("dbo.CommentObservations", "Observation_Id", "dbo.Observations");
            DropForeignKey("dbo.CommentObservations", "Comment_Id", "dbo.Comments");
            DropIndex("dbo.CommentObservations", new[] { "Observation_Id" });
            DropIndex("dbo.CommentObservations", new[] { "Comment_Id" });
            DropTable("dbo.CommentObservations");
            CreateIndex("dbo.Observations", "CommentId");
            AddForeignKey("dbo.Observations", "CommentId", "dbo.Comments", "Id");
        }
    }
}
