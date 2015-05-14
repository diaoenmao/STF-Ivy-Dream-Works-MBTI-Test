namespace Stanford.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Major", "Job_Id", "dbo.Job");
            DropIndex("dbo.Major", new[] { "Job_Id" });
            AddColumn("dbo.Job", "Job_Id", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Job", new[] { "Id" });
            AddPrimaryKey("dbo.Job", "Job_Id");
            DropColumn("dbo.Job", "Id");
            DropColumn("dbo.Job", "name");
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
                        Job_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Job", "name", c => c.String());
            AddColumn("dbo.Job", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Job", new[] { "Job_Id" });
            AddPrimaryKey("dbo.Job", "Id");
            DropColumn("dbo.Job", "Job_Id");
            CreateIndex("dbo.Major", "Job_Id");
            AddForeignKey("dbo.Major", "Job_Id", "dbo.Job", "Id");
        }
    }
}
