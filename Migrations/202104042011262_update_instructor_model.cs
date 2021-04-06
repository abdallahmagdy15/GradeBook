namespace LastLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_instructor_model : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Instructors", "DeptId", "dbo.Departments");
            DropIndex("dbo.Instructors", new[] { "DeptId" });
            DropTable("dbo.Instructors");
            CreateTable(
                "dbo.Instructors",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    FullName = c.String(nullable: false, maxLength: 150),
                    UserName = c.String(nullable: false, maxLength: 150),
                    Email = c.String(nullable: false, maxLength: 150),
                    Age = c.Int(nullable: false),
                    Gender = c.Int(nullable: false),
                    DeptId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DeptId, cascadeDelete: true)
                .Index(t => t.DeptId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructors", "DeptId", "dbo.Departments");
            DropIndex("dbo.Instructors", new[] { "DeptId" });
            DropTable("dbo.Instructors");
        }
    }
}
