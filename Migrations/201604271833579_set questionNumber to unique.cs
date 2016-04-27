namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setquestionNumbertounique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Questions", "QuestionNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Questions", new[] { "QuestionNumber" });
        }
    }
}
