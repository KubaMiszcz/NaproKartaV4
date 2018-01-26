namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
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
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        ObservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Observations", t => t.ObservationId, cascadeDelete: true)
                .Index(t => t.ObservationId);
            
            AlterColumn("dbo.Observations", "LetterId", c => c.Int());
            AlterColumn("dbo.Observations", "NumTimeId", c => c.Int());
            AlterColumn("dbo.Observations", "CipherId", c => c.Int());
            AlterColumn("dbo.Observations", "CipherCdId", c => c.Int());
            CreateIndex("dbo.Observations", "LetterId");
            CreateIndex("dbo.Observations", "NumTimeId");
            CreateIndex("dbo.Observations", "CipherId");
            CreateIndex("dbo.Observations", "CipherCdId");
            AddForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers", "Id");
            AddForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds", "Id");
            AddForeignKey("dbo.Observations", "LetterId", "dbo.Letters", "Id");
            AddForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes", "Id");
            DropColumn("dbo.Observations", "PictureUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Observations", "PictureUrl", c => c.String());
            DropForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes");
            DropForeignKey("dbo.Observations", "LetterId", "dbo.Letters");
            DropForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds");
            DropForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers");
            DropForeignKey("dbo.Pictures", "ObservationId", "dbo.Observations");
            DropIndex("dbo.Pictures", new[] { "ObservationId" });
            DropIndex("dbo.Observations", new[] { "CipherCdId" });
            DropIndex("dbo.Observations", new[] { "CipherId" });
            DropIndex("dbo.Observations", new[] { "NumTimeId" });
            DropIndex("dbo.Observations", new[] { "LetterId" });
            AlterColumn("dbo.Observations", "CipherCdId", c => c.Int(nullable: false));
            AlterColumn("dbo.Observations", "CipherId", c => c.Int(nullable: false));
            AlterColumn("dbo.Observations", "NumTimeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Observations", "LetterId", c => c.Int(nullable: false));
            DropTable("dbo.Pictures");
            CreateIndex("dbo.Observations", "CipherCdId");
            CreateIndex("dbo.Observations", "CipherId");
            CreateIndex("dbo.Observations", "NumTimeId");
            CreateIndex("dbo.Observations", "LetterId");
            AddForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Observations", "LetterId", "dbo.Letters", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers", "Id", cascadeDelete: true);
        }
    }
}
