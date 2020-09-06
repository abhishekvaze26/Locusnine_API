namespace EmployeeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeMobile", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "EmployeeMobile", c => c.String(nullable: false));
        }
    }
}
