namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cycles", "NumberInChart", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cycles", "NumberInChart", c => c.String());
        }
    }
}
