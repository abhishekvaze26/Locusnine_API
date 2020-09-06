using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeEmail { get; set; }
        [Required]
        public string EmployeeRole { get; set; }
        public string EmployeeMobile { get; set; }
        public string EmployeeStatus { get; set; }
    }
}