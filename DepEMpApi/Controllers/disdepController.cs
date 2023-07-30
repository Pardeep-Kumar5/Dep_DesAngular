using DepEMpApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepEMpApi.Controllers
{
    [Route("api/disdep")]
    [ApiController]
    public class disdepController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public disdepController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDepartment()
        {
            return Ok(_context.Departments.ToList());
        }
    }
}
