using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepEMpApi.Models
{
    public class Department
    {
    [Key]
        public int Dno { get; set; }
        [Required]
        public string Dname { get; set; }

    }
}

