
namespace LastLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updating_student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "UserName", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Students", "Email", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
            DropColumn("dbo.Students", "UserName");
        }
    }
}
