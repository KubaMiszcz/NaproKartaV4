namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Observations", new[] { "NumTimes_Id" });
            DropColumn("dbo.Observations", "NumTimeId");
            RenameColumn(table: "dbo.Observations", name: "NumTimes_Id", newName: "NumTimeId");
            AlterColumn("dbo.Observations", "NumTimeId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Observations", "NumTimeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Observations", new[] { "NumTimeId" });
            AlterColumn("dbo.Observations", "NumTimeId", c => c.String());
            RenameColumn(table: "dbo.Observations", name: "NumTimeId", newName: "NumTimes_Id");
            AddColumn("dbo.Observations", "NumTimeId", c => c.String());
            CreateIndex("dbo.Observations", "NumTimes_Id");
        }
    }
}
