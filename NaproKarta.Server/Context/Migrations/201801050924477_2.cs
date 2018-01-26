namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Observations", "CipherCd_Id", "dbo.CipherCds");
            DropIndex("dbo.Observations", new[] { "CipherCd_Id" });
            DropColumn("dbo.Observations", "CipherCdId");
            RenameColumn(table: "dbo.Observations", name: "CipherCd_Id", newName: "CipherCdId");
            DropPrimaryKey("dbo.CipherCds");
            AlterColumn("dbo.Observations", "CipherCdId", c => c.Int(nullable: false));
            AlterColumn("dbo.CipherCds", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Letters", "Value", c => c.String(maxLength: 3));
            AddPrimaryKey("dbo.CipherCds", "Id");
            CreateIndex("dbo.Observations", "CipherCdId");
            AddForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds");
            DropIndex("dbo.Observations", new[] { "CipherCdId" });
            DropPrimaryKey("dbo.CipherCds");
            AlterColumn("dbo.Letters", "Value", c => c.String());
            AlterColumn("dbo.CipherCds", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Observations", "CipherCdId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.CipherCds", "Id");
            RenameColumn(table: "dbo.Observations", name: "CipherCdId", newName: "CipherCd_Id");
            AddColumn("dbo.Observations", "CipherCdId", c => c.Int(nullable: false));
            CreateIndex("dbo.Observations", "CipherCd_Id");
            AddForeignKey("dbo.Observations", "CipherCd_Id", "dbo.CipherCds", "Id");
        }
    }
}
