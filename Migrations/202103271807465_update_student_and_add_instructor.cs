namespace LastLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_student_and_add_instructor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudCrsGrades", "StdId", "dbo.Students");
            DropIndex("dbo.StudCrsGrades", new[] { "StdId" });
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.StudCrsGrades");
            AlterColumn("dbo.Students", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudCrsGrades", "StdId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Students", "Id");
            AddPrimaryKey("dbo.StudCrsGrades", new[] { "StdId", "CrsId" });
            CreateIndex("dbo.StudCrsGrades", "StdId");
            AddForeignKey("dbo.StudCrsGrades", "StdId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudCrsGrades", "StdId", "dbo.Students");
            DropIndex("dbo.StudCrsGrades", new[] { "StdId" });
            DropPrimaryKey("dbo.StudCrsGrades");
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.StudCrsGrades", "StdId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StudCrsGrades", new[] { "StdId", "CrsId" });
            AddPrimaryKey("dbo.Students", "Id");
            CreateIndex("dbo.StudCrsGrades", "StdId");
            AddForeignKey("dbo.StudCrsGrades", "StdId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
