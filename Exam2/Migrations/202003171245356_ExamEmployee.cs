namespace Exam2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExamEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                        Department = c.String(),
                        Salary = c.Double(nullable: false),
                        CateroryID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Categories", t => t.CateroryID)
                .Index(t => t.CateroryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "CateroryID", "dbo.Categories");
            DropIndex("dbo.Employees", new[] { "CateroryID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Categories");
        }
    }
}
