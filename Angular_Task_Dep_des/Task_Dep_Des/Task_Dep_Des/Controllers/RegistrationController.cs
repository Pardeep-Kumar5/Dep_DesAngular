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
    [Route("api/Registration")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetRegister")]
        public IActionResult GetRegister()
        {
            var employeelist = _context.Employees.Include(e => e.department).Include(e => e.designation).ToList();
            return Ok(employeelist);
        }
        [HttpPost]
        public IActionResult SaveRegister([FromBody]Employee employee)
        {
            if(employee !=null && ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return Ok();

            }
      return BadRequest();
        }
        [HttpPut]
        [Route("UpdateRegister")]
        public IActionResult UpdateRegister([FromBody] Employee employee)
        {
            if (employee != null && ModelState.IsValid)
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return Ok();

            }
            return CreatedAtRoute("GetRegister", new { id = employee.Id }, employee);
        }
    }
}
