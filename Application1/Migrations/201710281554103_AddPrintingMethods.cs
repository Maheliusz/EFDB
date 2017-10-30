namespace Application1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrintingMethods : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Posts", new[] { "BlogId" });
            CreateIndex("dbo.Posts", "BlogID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "BlogID" });
            CreateIndex("dbo.Posts", "BlogId");
        }
    }
}
