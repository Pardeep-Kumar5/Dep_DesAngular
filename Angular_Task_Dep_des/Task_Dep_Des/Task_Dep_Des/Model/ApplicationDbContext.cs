﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Dep_Des.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet <Department> Departments { get; set; }
        public DbSet <Designation> Designations { get; set; }
        public DbSet <Employee> Employees { get; set; }
    }
}
