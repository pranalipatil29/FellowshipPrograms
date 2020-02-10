using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using BusinessLayer.Service;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Service;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeBL employeeBL;
        public EmployeeController(IEmployeeBL employeeBl)
        {
            this.employeeBL = employeeBl;
        }


        // GET: api/Employee
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(employeeBL.DisplayEmployeeInfo().ToList());
        }


        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(EmployeeModel employeeModel)
        {
            var result= employeeBL.AddEmployee(employeeModel);
            return Ok(new { result });
        }

        // PUT: api/Employee/5
        [HttpPut("UpdateEmployee/{id}")]
        public IActionResult Put(EmployeeModel employeeModel, int id)
        {
            var result= employeeBL.UpdateEmployeeInfo(employeeModel, id);
            return Ok(new { result });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
           var result = employeeBL.DeleteEmployeeInfo(id);
            return Ok(new { result });
        }
    }
}
