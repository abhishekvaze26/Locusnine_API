namespace EmployeeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employeeStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeStatus");
        }
    }
}
