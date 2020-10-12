namespace LeBataillon.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameDateTime = c.DateTime(nullable: false),
                        TeamDefendant = c.Int(nullable: false),
                        TeamAttacker = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NickName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        Captain = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
            DropTable("dbo.Games");
        }
    }
}
