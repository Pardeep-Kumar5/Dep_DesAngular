using DepEMpApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepEMpApi.Controllers
{
    [Route("api/DepEmp")]
    [ApiController]
    public class DepEmpController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DepEmpController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetEmployee(int empId)
        {
            var employee = _context.Employees.Where(u => u.DepartmentId == empId).ToList();
            return Ok(employee);

        }
        [HttpPost]
        public IActionResult GetEmployee([FromBody] Employee employee)
        { 
            if (employee != null && ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut]
        public IActionResult UpdateEmployees([FromBody]Employee employee)
        {
            if (employee != null && ModelState.IsValid)
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employeeInDb = _context.Employees.Find(id);
            if (employeeInDb == null) return NotFound();
            _context.Employees.Remove(employeeInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
