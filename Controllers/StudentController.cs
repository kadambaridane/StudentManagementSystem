using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        private readonly IConfiguration _config;

        public StudentController(IStudentService service, IConfiguration config)
        {
            _service = service;
            _config = config;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _service.GetAll();

            if (students == null || students.Count == 0)
                return NotFound(new { message = "No students found" });

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _service.GetById(id);

            if (student == null)
                return NotFound(new { message = "Student not found" });

            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Student student)
        {
            if (student == null)
                return BadRequest(new { message = "Invalid student data" });

            var result = await _service.Add(student);

            return Ok(new
            {
                message = "Student added successfully",
                data = result
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Student student)
        {
            if (student == null)
                return BadRequest(new { message = "Invalid student data" });

            var result = await _service.Update(id, student);

            if (result == null)
                return NotFound(new { message = "Student not found" });

            return Ok(new
            {
                message = "Student updated successfully",
                data = result
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _service.Delete(id);

            if (!isDeleted)
                return NotFound(new { message = "Student not found" });

            return Ok(new { message = "Student deleted successfully" });
        }

        [HttpGet("token")]
        [AllowAnonymous]
        public IActionResult GetToken()
        {
            var key = _config["Jwt:Key"]
          ?? throw new Exception("JWT Key missing");

            var issuer = _config["Jwt:Issuer"]
                         ?? throw new Exception("JWT Issuer missing");

            var token = JwtHelper.GenerateToken(key, issuer);

            return Ok(new
            {
                token = token,
                message = "Use this token in Authorization header"
            });
        }
    }
}