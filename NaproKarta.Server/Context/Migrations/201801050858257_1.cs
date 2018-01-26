namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers");
            DropForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds");
            DropForeignKey("dbo.Observations", "LetterId", "dbo.Letters");
            DropForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes");
            DropIndex("dbo.Observations", new[] { "LetterId" });
            DropIndex("dbo.Observations", new[] { "NumTimeId" });
            DropIndex("dbo.Observations", new[] { "CipherId" });
            DropIndex("dbo.Observations", new[] { "CipherCdId" });
            DropPrimaryKey("dbo.Ciphers");
            DropPrimaryKey("dbo.Letters");
            DropPrimaryKey("dbo.NumTimes");
            AddColumn("dbo.Observations", "CipherCd_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Ciphers", "Value", c => c.String());
            AddColumn("dbo.CipherCds", "Value", c => c.String());
            AddColumn("dbo.Letters", "Value", c => c.String(maxLength: 3));
            AddColumn("dbo.NumTimes", "Value", c => c.String());
            AlterColumn("dbo.Observations", "LetterId", c => c.Int(nullable: false));
            AlterColumn("dbo.Observations", "NumTimeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Observations", "CipherId", c => c.Int(nullable: false));
            AlterColumn("dbo.Observations", "CipherCdId", c => c.Int(nullable: false));
            AlterColumn("dbo.Ciphers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Letters", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.NumTimes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Ciphers", "Id");
            AddPrimaryKey("dbo.Letters", "Id");
            AddPrimaryKey("dbo.NumTimes", "Id");
            CreateIndex("dbo.Observations", "LetterId");
            CreateIndex("dbo.Observations", "NumTimeId");
            CreateIndex("dbo.Observations", "CipherId");
            CreateIndex("dbo.Observations", "CipherCd_Id");
            AddForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Observations", "CipherCd_Id", "dbo.CipherCds", "Id");
            AddForeignKey("dbo.Observations", "LetterId", "dbo.Letters", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes");
            DropForeignKey("dbo.Observations", "LetterId", "dbo.Letters");
            DropForeignKey("dbo.Observations", "CipherCd_Id", "dbo.CipherCds");
            DropForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers");
            DropIndex("dbo.Observations", new[] { "CipherCd_Id" });
            DropIndex("dbo.Observations", new[] { "CipherId" });
            DropIndex("dbo.Observations", new[] { "NumTimeId" });
            DropIndex("dbo.Observations", new[] { "LetterId" });
            DropPrimaryKey("dbo.NumTimes");
            DropPrimaryKey("dbo.Letters");
            DropPrimaryKey("dbo.Ciphers");
            AlterColumn("dbo.NumTimes", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Letters", "Id", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Ciphers", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Observations", "CipherCdId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Observations", "CipherId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Observations", "NumTimeId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Observations", "LetterId", c => c.String(maxLength: 3));
            DropColumn("dbo.NumTimes", "Value");
            DropColumn("dbo.Letters", "Value");
            DropColumn("dbo.CipherCds", "Value");
            DropColumn("dbo.Ciphers", "Value");
            DropColumn("dbo.Observations", "CipherCd_Id");
            AddPrimaryKey("dbo.NumTimes", "Id");
            AddPrimaryKey("dbo.Letters", "Id");
            AddPrimaryKey("dbo.Ciphers", "Id");
            CreateIndex("dbo.Observations", "CipherCdId");
            CreateIndex("dbo.Observations", "CipherId");
            CreateIndex("dbo.Observations", "NumTimeId");
            CreateIndex("dbo.Observations", "LetterId");
            AddForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes", "Id");
            AddForeignKey("dbo.Observations", "LetterId", "dbo.Letters", "Id");
            AddForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds", "Id");
            AddForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers", "Id");
        }
    }
}
