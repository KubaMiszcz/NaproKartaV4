namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Observations", new[] { "Letter_Id", "Letter_IsB" }, "dbo.Letters");
            DropIndex("dbo.Observations", new[] { "Letter_Id", "Letter_IsB" });
            DropColumn("dbo.Observations", "LetterId");
            RenameColumn(table: "dbo.Observations", name: "Letter_Id", newName: "LetterId");
            DropPrimaryKey("dbo.Letters");
            AddColumn("dbo.Observations", "IsB", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Observations", "LetterId", c => c.String(maxLength: 3));
            AddPrimaryKey("dbo.Letters", "Id");
            CreateIndex("dbo.Observations", "LetterId");
            AddForeignKey("dbo.Observations", "LetterId", "dbo.Letters", "Id");
            DropColumn("dbo.Observations", "Letter_IsB");
            DropColumn("dbo.Letters", "IsB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Letters", "IsB", c => c.Boolean(nullable: false));
            AddColumn("dbo.Observations", "Letter_IsB", c => c.Boolean());
            DropForeignKey("dbo.Observations", "LetterId", "dbo.Letters");
            DropIndex("dbo.Observations", new[] { "LetterId" });
            DropPrimaryKey("dbo.Letters");
            AlterColumn("dbo.Observations", "LetterId", c => c.String());
            DropColumn("dbo.Observations", "IsB");
            AddPrimaryKey("dbo.Letters", new[] { "Id", "IsB" });
            RenameColumn(table: "dbo.Observations", name: "LetterId", newName: "Letter_Id");
            AddColumn("dbo.Observations", "LetterId", c => c.String());
            CreateIndex("dbo.Observations", new[] { "Letter_Id", "Letter_IsB" });
            AddForeignKey("dbo.Observations", new[] { "Letter_Id", "Letter_IsB" }, "dbo.Letters", new[] { "Id", "IsB" });
        }
    }
}
