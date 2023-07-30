using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Dep_Des.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
      
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department department { get; set; }
        [Display(Name = "Designation")]

        public int DesignationId { get; set; }
        public Designation designation { get; set; }
    }
}
