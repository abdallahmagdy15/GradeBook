namespace LastLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updating_student_instructor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "DeptId", "dbo.Departments");
            DropForeignKey("dbo.Instructors", "DeptId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DeptId" });
            DropIndex("dbo.Instructors", new[] { "DeptId" });
            AlterColumn("dbo.Students", "DeptId", c => c.Int());
            AlterColumn("dbo.Instructors", "DeptId", c => c.Int());
            CreateIndex("dbo.Students", "DeptId");
            CreateIndex("dbo.Instructors", "DeptId");
            AddForeignKey("dbo.Students", "DeptId", "dbo.Departments", "Id");
            AddForeignKey("dbo.Instructors", "DeptId", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructors", "DeptId", "dbo.Departments");
            DropForeignKey("dbo.Students", "DeptId", "dbo.Departments");
            DropIndex("dbo.Instructors", new[] { "DeptId" });
            DropIndex("dbo.Students", new[] { "DeptId" });
            AlterColumn("dbo.Instructors", "DeptId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "DeptId", c => c.Int(nullable: false));
            CreateIndex("dbo.Instructors", "DeptId");
            CreateIndex("dbo.Students", "DeptId");
            AddForeignKey("dbo.Instructors", "DeptId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "DeptId", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
