using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DHH.Models
{
    public class Department
    {
        [Key]
        public int Dept_ID { get; set; }
        [Required(ErrorMessage ="Depart Name is Required")]
        public string Dept_Name { get; set;}
        public string Dept_Phone { get; set; }

    }
 
}
