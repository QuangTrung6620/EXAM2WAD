using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Exam2.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("EmployeeID")]
        public string EmployeeID { get; set; }
        [DisplayName("Full name")]
        [Required(ErrorMessage = "Vui long nhap full name.")]
        public string EmployeeName { get; set; }
        [DisplayName("Deparment")]
        [Required(ErrorMessage = "Vui long nhap.")]
        public string Department { get; set; }
        public double Salary { get; set; }
        [ForeignKey("Category")]
        public string CateroryID { get; set; }
        public virtual Category Category { get; set; }
    }
}