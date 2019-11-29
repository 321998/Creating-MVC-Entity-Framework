using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DHH.Models
{
    public class Employee
    {
        [Key]
        public int Emp_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public int Dept_ID { get; set; }
    }
}
