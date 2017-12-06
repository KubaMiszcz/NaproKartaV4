namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Charts", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Charts", "Name", c => c.String());
        }
    }
}
