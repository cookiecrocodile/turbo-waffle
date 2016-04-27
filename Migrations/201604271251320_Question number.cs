namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Questionnumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "QuestionNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "QuestionNumber");
        }
    }
}
