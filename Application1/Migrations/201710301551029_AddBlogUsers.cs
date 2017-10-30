namespace Application1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogUsers : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Blogs", name: "User_UserName", newName: "UserName");
            RenameIndex(table: "dbo.Blogs", name: "IX_User_UserName", newName: "IX_UserName");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Blogs", name: "IX_UserName", newName: "IX_User_UserName");
            RenameColumn(table: "dbo.Blogs", name: "UserName", newName: "User_UserName");
        }
    }
}
