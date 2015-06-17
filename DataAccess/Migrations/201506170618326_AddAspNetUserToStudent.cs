namespace VirtualSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAspNetUserToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Students", "User_Id");
            AddForeignKey("dbo.Students", "User_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Students", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "UserId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Students", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "User_Id" });
            DropColumn("dbo.Students", "User_Id");
        }
    }
}
