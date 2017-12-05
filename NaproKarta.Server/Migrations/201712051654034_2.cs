namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Charts", "UserDataId", "dbo.UserDatas");
            DropIndex("dbo.Charts", new[] { "UserDataId" });
            RenameColumn(table: "dbo.Charts", name: "UserDataId", newName: "UserData_Id");
            AddColumn("dbo.Charts", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Charts", "User_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Charts", "UserData_Id", c => c.Int());
            CreateIndex("dbo.Charts", "User_Id");
            CreateIndex("dbo.Charts", "UserData_Id");
            AddForeignKey("dbo.Charts", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Charts", "UserData_Id", "dbo.UserDatas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Charts", "UserData_Id", "dbo.UserDatas");
            DropForeignKey("dbo.Charts", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Charts", new[] { "UserData_Id" });
            DropIndex("dbo.Charts", new[] { "User_Id" });
            AlterColumn("dbo.Charts", "UserData_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Charts", "User_Id");
            DropColumn("dbo.Charts", "UserId");
            RenameColumn(table: "dbo.Charts", name: "UserData_Id", newName: "UserDataId");
            CreateIndex("dbo.Charts", "UserDataId");
            AddForeignKey("dbo.Charts", "UserDataId", "dbo.UserDatas", "Id", cascadeDelete: true);
        }
    }
}
