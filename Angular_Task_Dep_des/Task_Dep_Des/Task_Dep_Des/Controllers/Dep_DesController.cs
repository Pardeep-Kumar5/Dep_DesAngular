using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Dep_Des.Model;

namespace Task_Dep_Des.Controllers
{
    [Route("api/Dep_Des")]
    [ApiController]
    public class Dep_DesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public Dep_DesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetDepartment")]
        public IActionResult GetDepartment()
        {
            var Dep = _context.Departments.ToList();
            return Ok(Dep);
        }
        [HttpGet]
        [Route("GetDesignation")]
        public IActionResult GetDesignation()
        {
            var Des = _context.Designations.ToList();
            return Ok(Des);
        }

    }
}
