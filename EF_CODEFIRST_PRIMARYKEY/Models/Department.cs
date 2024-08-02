using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_CODEFIRST_PRIMARYKEY.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        //collection navigation property
        public  ICollection<Employee> Employees { get; set; }
    }
}