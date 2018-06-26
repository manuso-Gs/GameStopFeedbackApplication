namespace GameStopFeedbackApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationUpdates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "EmailAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "EmailAddress", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
