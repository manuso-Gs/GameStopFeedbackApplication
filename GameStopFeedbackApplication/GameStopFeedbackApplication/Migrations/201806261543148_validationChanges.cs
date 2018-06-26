namespace GameStopFeedbackApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Feedbacks", "MostLiked", c => c.String(nullable: false));
            AlterColumn("dbo.Feedbacks", "MostDisliked", c => c.String(nullable: false));
            AlterColumn("dbo.Feedbacks", "MostLikeToSee", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Users", "EmailAddress", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Gender", c => c.String());
            AlterColumn("dbo.Users", "EmailAddress", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Feedbacks", "MostLikeToSee", c => c.String());
            AlterColumn("dbo.Feedbacks", "MostDisliked", c => c.String());
            AlterColumn("dbo.Feedbacks", "MostLiked", c => c.String());
        }
    }
}
