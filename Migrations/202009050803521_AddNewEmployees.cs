namespace EmployeeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewEmployees : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Employees(EmployeeName,EmployeeEmail,EmployeeRole,EmployeeMobile,EmployeeStatus) values('Steven Gerrard','stevie@gmail.com','Admin','9876543210','Active')");
        }
        
        public override void Down()
        {
        }
    }
}
