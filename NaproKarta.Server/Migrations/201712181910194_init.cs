namespace NaproKarta.Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Charts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Title = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Cycles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChartId = c.Int(nullable: false),
                        NumberInChart = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Charts", t => t.ChartId, cascadeDelete: true)
                .Index(t => t.ChartId);
            
            CreateTable(
                "dbo.Observations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CycleId = c.Int(nullable: false),
                        MarkerId = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        LetterId = c.String(maxLength: 3),
                        IsB = c.Boolean(nullable: false),
                        NumTimeId = c.String(maxLength: 128),
                        CipherId = c.String(maxLength: 128),
                        CipherCdId = c.String(maxLength: 128),
                        CommentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ciphers", t => t.CipherId)
                .ForeignKey("dbo.CipherCds", t => t.CipherCdId)
                .ForeignKey("dbo.Comments", t => t.CommentId, cascadeDelete: true)
                .ForeignKey("dbo.Cycles", t => t.CycleId, cascadeDelete: true)
                .ForeignKey("dbo.Letters", t => t.LetterId)
                .ForeignKey("dbo.Markers", t => t.MarkerId)
                .ForeignKey("dbo.NumTimes", t => t.NumTimeId)
                .Index(t => t.CycleId)
                .Index(t => t.MarkerId)
                .Index(t => t.LetterId)
                .Index(t => t.NumTimeId)
                .Index(t => t.CipherId)
                .Index(t => t.CipherCdId)
                .Index(t => t.CommentId);
            
            CreateTable(
                "dbo.Ciphers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CipherCds",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Letters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Markers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ObservationNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        IsImportant = c.Boolean(nullable: false),
                        ObservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Observations", t => t.ObservationId, cascadeDelete: true)
                .Index(t => t.ObservationId);
            
            CreateTable(
                "dbo.NumTimes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        LastLoginDate = c.DateTime(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Charts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Observations", "NumTimeId", "dbo.NumTimes");
            DropForeignKey("dbo.ObservationNotes", "ObservationId", "dbo.Observations");
            DropForeignKey("dbo.Observations", "MarkerId", "dbo.Markers");
            DropForeignKey("dbo.Observations", "LetterId", "dbo.Letters");
            DropForeignKey("dbo.Observations", "CycleId", "dbo.Cycles");
            DropForeignKey("dbo.Observations", "CommentId", "dbo.Comments");
            DropForeignKey("dbo.Observations", "CipherCdId", "dbo.CipherCds");
            DropForeignKey("dbo.Observations", "CipherId", "dbo.Ciphers");
            DropForeignKey("dbo.Cycles", "ChartId", "dbo.Charts");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.ObservationNotes", new[] { "ObservationId" });
            DropIndex("dbo.Observations", new[] { "CommentId" });
            DropIndex("dbo.Observations", new[] { "CipherCdId" });
            DropIndex("dbo.Observations", new[] { "CipherId" });
            DropIndex("dbo.Observations", new[] { "NumTimeId" });
            DropIndex("dbo.Observations", new[] { "LetterId" });
            DropIndex("dbo.Observations", new[] { "MarkerId" });
            DropIndex("dbo.Observations", new[] { "CycleId" });
            DropIndex("dbo.Cycles", new[] { "ChartId" });
            DropIndex("dbo.Charts", new[] { "UserId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.NumTimes");
            DropTable("dbo.ObservationNotes");
            DropTable("dbo.Markers");
            DropTable("dbo.Letters");
            DropTable("dbo.Comments");
            DropTable("dbo.CipherCds");
            DropTable("dbo.Ciphers");
            DropTable("dbo.Observations");
            DropTable("dbo.Cycles");
            DropTable("dbo.Charts");
        }
    }
}
