using Microsoft.AspNetCore.Mvc;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using System.Collections.Generic;

namespace SkillManagement.WebAPI.Controllers
{
    public class EmployeeController : ControllerBase
    {
        #region Propertirs
        ISQLEmployeeService _sqlEmployeeService;
        #endregion

        #region Constructors
        public EmployeeController(ISQLEmployeeService sqlEmployeeService)
        {
            _sqlEmployeeService = sqlEmployeeService;
        }
        #endregion

        #region APIs
        // GET: Get all employees
        [Route("Employees")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _sqlEmployeeService.GetAllEmployees();
        }

        // GET: Get employee by id
        [Route("Employee/{Id}")]
        [HttpGet]
        public Product Get(long Id)
        {
            return _sqlEmployeeService.GetEmployeeById(Id);
        }

        // POST: Add new employee
        [Route("Employees")]
        [HttpPost]
        public long Post([FromBody]Product employee)
        {
            return _sqlEmployeeService.AddEmployee(employee);
        }

        // PUT: Update existing employee
        [Route("Employee/{employee}")]
        [HttpPut]
        public void Put([FromBody]Product employee)
        {
            _sqlEmployeeService.UpdateEmployee(employee);
        }

        // DELETE: Delete existing employee
        [Route("Employee/{employee}")]
        [HttpDelete]
        public void Delete([FromBody]Product employee)
        {
            _sqlEmployeeService.DeleteEmployee(employee);
        }
        #endregion
    }
}
