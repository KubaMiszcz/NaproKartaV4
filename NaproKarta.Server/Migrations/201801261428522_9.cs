namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Observations", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Observations", "Date", c => c.DateTime(nullable: false));
        }
    }
}
