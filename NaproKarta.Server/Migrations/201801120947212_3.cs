namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Observations", "CommentId", "dbo.Comments");
            DropIndex("dbo.Observations", new[] { "CommentId" });
            AddColumn("dbo.Observations", "PeakDayNumber", c => c.Int());
            AlterColumn("dbo.Observations", "CommentId", c => c.Int());
            CreateIndex("dbo.Observations", "CommentId");
            AddForeignKey("dbo.Observations", "CommentId", "dbo.Comments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Observations", "CommentId", "dbo.Comments");
            DropIndex("dbo.Observations", new[] { "CommentId" });
            AlterColumn("dbo.Observations", "CommentId", c => c.Int(nullable: false));
            DropColumn("dbo.Observations", "PeakDayNumber");
            CreateIndex("dbo.Observations", "CommentId");
            AddForeignKey("dbo.Observations", "CommentId", "dbo.Comments", "Id", cascadeDelete: true);
        }
    }
}
