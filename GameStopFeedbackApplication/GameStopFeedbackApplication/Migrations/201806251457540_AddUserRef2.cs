namespace GameStopFeedbackApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserRef2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Feedbacks", "UserId_Id", "dbo.Users");
            DropIndex("dbo.Feedbacks", new[] { "UserId_Id" });
            RenameColumn(table: "dbo.Feedbacks", name: "UserId_Id", newName: "UserId");
            AlterColumn("dbo.Feedbacks", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Feedbacks", "UserId");
            AddForeignKey("dbo.Feedbacks", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "UserId", "dbo.Users");
            DropIndex("dbo.Feedbacks", new[] { "UserId" });
            AlterColumn("dbo.Feedbacks", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Feedbacks", name: "UserId", newName: "UserId_Id");
            CreateIndex("dbo.Feedbacks", "UserId_Id");
            AddForeignKey("dbo.Feedbacks", "UserId_Id", "dbo.Users", "Id");
        }
    }
}
