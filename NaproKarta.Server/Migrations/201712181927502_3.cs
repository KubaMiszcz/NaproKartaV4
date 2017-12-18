namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "LastLoginDate");
            DropColumn("dbo.AspNetUsers", "RegisterDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "RegisterDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastLoginDate", c => c.DateTime(nullable: false));
        }
    }
}
