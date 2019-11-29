using DHH.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DHH.Context
{
    public class DepartmentContext: DbContext
    {
        public DepartmentContext() : base("EESSS") {
        
        }

        public DbSet<Department> departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
