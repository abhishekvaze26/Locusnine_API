namespace EmployeeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        EmployeeEmail = c.String(nullable: false),
                        EmployeeRole = c.String(nullable: false),
                        EmployeeMobile = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
