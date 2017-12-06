namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Charts", new[] { "User_Id" });
            DropColumn("dbo.Charts", "UserId");
            RenameColumn(table: "dbo.Charts", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Charts", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Charts", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Charts", new[] { "UserId" });
            AlterColumn("dbo.Charts", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Charts", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Charts", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Charts", "User_Id");
        }
    }
}
