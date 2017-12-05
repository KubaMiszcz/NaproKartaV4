namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1th : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Name = c.String(),
                        Email = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Charts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserDataId = c.Int(nullable: false),
                        Name = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserDatas", t => t.UserDataId, cascadeDelete: true)
                .Index(t => t.UserDataId);
            
            CreateTable(
                "dbo.Cycles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChartId = c.Int(nullable: false),
                        NumberInChart = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Charts", t => t.ChartId, cascadeDelete: true)
                .Index(t => t.ChartId);
            
            CreateTable(
                "dbo.Observations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CycleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cycles", t => t.CycleId, cascadeDelete: true)
                .Index(t => t.CycleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDatas", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Charts", "UserDataId", "dbo.UserDatas");
            DropForeignKey("dbo.Cycles", "ChartId", "dbo.Charts");
            DropForeignKey("dbo.Observations", "CycleId", "dbo.Cycles");
            DropIndex("dbo.Observations", new[] { "CycleId" });
            DropIndex("dbo.Cycles", new[] { "ChartId" });
            DropIndex("dbo.Charts", new[] { "UserDataId" });
            DropIndex("dbo.UserDatas", new[] { "UserId" });
            DropTable("dbo.Observations");
            DropTable("dbo.Cycles");
            DropTable("dbo.Charts");
            DropTable("dbo.UserDatas");
        }
    }
}
