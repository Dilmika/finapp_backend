using ASPNETCoreApplication.Models;
using finappBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace finappBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public ClassroomController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllClassrooms")]
        public Response GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.GetAllClassrooms(connection);

            return response;
        }

        [HttpPost]
        [Route("AddClassroom")]
        public Response AddStudent(Classroom classroom)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.AddClassroom(connection, classroom);

            return response;
        }


    }
}
