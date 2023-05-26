using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;
        public EmployeeController(IEmployeeService ser)
        {
            service = ser;
        }
        // GET: api/Employee/GetAllEmployees
        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            try
            {
                return new ObjectResult(service.GetAllEmployees());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET  api/Employee/GetEmployeeById/1
        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                return new ObjectResult(service.GetEmployeeById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee emp)
        {
            try
            {
                int res = service.AddEmployee(emp);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPost]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] Employee emp)
        {
            try
            {
                int res = service.UpdateEmployee(emp);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpGet]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                int res = service.DeleteEmployee(id);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
