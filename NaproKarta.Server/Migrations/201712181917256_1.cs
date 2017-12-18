namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Observations", "NumberInCycle", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Observations", "NumberInCycle");
        }
    }
}
