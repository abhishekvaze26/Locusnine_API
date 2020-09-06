namespace EmployeeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployees : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Employees(EmployeeName,EmployeeEmail,EmployeeRole,EmployeeMobile) values('Steven Gerrard','stevie@gmail.com','Admin','9876543210')");
        }
        
        public override void Down()
        {
        }
    }
}
