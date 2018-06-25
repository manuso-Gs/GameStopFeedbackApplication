namespace GameStopFeedbackApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserRef : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feedbacks", "UserId_Id", c => c.Int());
            CreateIndex("dbo.Feedbacks", "UserId_Id");
            AddForeignKey("dbo.Feedbacks", "UserId_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "UserId_Id", "dbo.Users");
            DropIndex("dbo.Feedbacks", new[] { "UserId_Id" });
            DropColumn("dbo.Feedbacks", "UserId_Id");
        }
    }
}
