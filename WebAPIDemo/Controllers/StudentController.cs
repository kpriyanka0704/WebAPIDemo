using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;
        public StudentController(IStudentService ser)
        {
            service = ser;
        }
        // GET: api/Student/GetAllStudents
        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                return new ObjectResult(service.GetAllStudents());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET  api/Student/GetStudentById/1
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                return new ObjectResult(service.GetStudentById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<StudentController>
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent([FromBody] Student stud)
        {
            try
            {
                int res = service.AddStudent(stud);
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

        // PUT api/<StudentController>/5
        [HttpPost]
        [Route("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody] Student stud)
        {
            try
            {
                int res = service.UpdateStudent(stud);
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

        // DELETE api/<StudentController>/5
        [HttpGet]
        [Route("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                int res = service.DeleteStudent(id);
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
