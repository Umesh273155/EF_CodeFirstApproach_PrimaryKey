using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_CODEFIRST_PRIMARYKEY.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("conn") {
        
        }
        public DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<EF_CODEFIRST_PRIMARYKEY.Models.Department> Departments { get; set; }
    }
}   