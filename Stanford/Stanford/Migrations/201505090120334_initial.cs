namespace Stanford.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Major", "ChrTrait_Id", "dbo.ChrTrait");
            DropIndex("dbo.Major", new[] { "ChrTrait_Id" });
            AddColumn("dbo.ChrTrait", "majorsStr", c => c.String());
            DropTable("dbo.Major");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Major",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        ChrTrait_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.ChrTrait", "majorsStr");
            CreateIndex("dbo.Major", "ChrTrait_Id");
            AddForeignKey("dbo.Major", "ChrTrait_Id", "dbo.ChrTrait", "Id");
        }
    }
}
