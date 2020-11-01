using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StudentManagement.Repository;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo studentRepository;

        private readonly IConfiguration _configuration;
        public StudentsController(IStudentRepo studentRepo, IConfiguration configuration)
        {
            this.studentRepository = studentRepo;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllStudentInfo()
        {
            try
            {
                return Ok(await studentRepository.GetAllStudentInfo());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
        [HttpPost]
        public async Task<IActionResult> Login()
        {

            var claims = new[]
            {
            new Claim(ClaimTypes.Name, "Test")
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok( new { Token = new JwtSecurityTokenHandler().WriteToken(token) } );
        }
           [HttpGet("{id:int}")]
        public async Task<ActionResult> GetStudentDetailsById(int id)
        {
            try
            {
                return Ok(await studentRepository.GetStudentDetailsById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
        [HttpGet("getmarks/{id}")]
        public async Task<ActionResult> GetStudentMarksID(int id)
        {
            try
            {
                return Ok(await studentRepository.GetStudentMarksID(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
    }
}
