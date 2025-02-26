using ett1_web_api.Models;
using ett1_web_api.Data;
using Microsoft.AspNetCore.Mvc;

namespace ett1_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentsController(StudentContext context)
        {
            _context = context;
        }

        // POST: api/Students/CreateStudent
        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Student added successfully", student });
        }
    }
}
