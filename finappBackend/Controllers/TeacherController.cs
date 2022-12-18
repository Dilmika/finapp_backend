using ASPNETCoreApplication.Models;
using finappBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace finappBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public TeacherController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllTeachers")]
        public Response GetAllTeachers()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.GetAllTeachers(connection);

            return response;
        }

        [HttpPost]
        [Route("AddTeacher")]
        public Response AddTeacher(Teacher teacher)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.AddTeacher(connection, teacher);

            return response;
        }
    }
}
