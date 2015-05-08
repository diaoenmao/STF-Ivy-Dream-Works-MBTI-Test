namespace Stanford.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChrTrait",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Major",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        ChrTrait_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChrTrait", t => t.ChrTrait_Id)
                .Index(t => t.ChrTrait_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Major", new[] { "ChrTrait_Id" });
            DropForeignKey("dbo.Major", "ChrTrait_Id", "dbo.ChrTrait");
            DropTable("dbo.Major");
            DropTable("dbo.ChrTrait");
        }
    }
}
