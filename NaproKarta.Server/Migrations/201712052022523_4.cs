namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Charts", "UserData_Id", "dbo.UserDatas");
            DropForeignKey("dbo.UserDatas", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Charts", new[] { "UserData_Id" });
            DropIndex("dbo.UserDatas", new[] { "UserId" });
            DropColumn("dbo.Charts", "UserData_Id");
            DropTable("dbo.UserDatas");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Charts", "UserData_Id", c => c.Int());
            CreateIndex("dbo.UserDatas", "UserId");
            CreateIndex("dbo.Charts", "UserData_Id");
            AddForeignKey("dbo.UserDatas", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Charts", "UserData_Id", "dbo.UserDatas", "Id");
        }
    }
}
