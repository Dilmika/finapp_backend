using ASPNETCoreApplication.Models;
using finappBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace finappBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public StudentController(IConfiguration configuration)
        {
            _configuration= configuration;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public Response GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.GetAllStudents(connection);

            return response;
        }

        [HttpPost]
        [Route("AddStudent")]
        public Response AddStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.AddStudent(connection, student);

            return response;
        }

    }
}
