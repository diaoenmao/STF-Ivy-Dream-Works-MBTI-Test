namespace Stanford.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChrTrait", "jobsStr", c => c.String());
            DropColumn("dbo.ChrTrait", "majorsStr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChrTrait", "majorsStr", c => c.String());
            DropColumn("dbo.ChrTrait", "jobsStr");
        }
    }
}
