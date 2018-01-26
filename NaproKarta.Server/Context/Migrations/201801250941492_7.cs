namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes");
            DropIndex("dbo.Observations", new[] { "NumTimeId" });
            AddColumn("dbo.Observations", "NumTimes_Id", c => c.Int());
            CreateIndex("dbo.Observations", "NumTimes_Id");
            AddForeignKey("dbo.Observations", "NumTimes_Id", "dbo.NumTimes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Observations", "NumTimes_Id", "dbo.NumTimes");
            DropIndex("dbo.Observations", new[] { "NumTimes_Id" });
            DropColumn("dbo.Observations", "NumTimes_Id");
            CreateIndex("dbo.Observations", "NumTimeId");
            AddForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes", "Id");
        }
    }
}
