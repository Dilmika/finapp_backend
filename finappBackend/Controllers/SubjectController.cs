using ASPNETCoreApplication.Models;
using finappBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace finappBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public SubjectController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllSubjects")]
        public Response GetAllSubjects()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.GetAllSubjects(connection);

            return response;
        }

        [HttpPost]
        [Route("AddSubject")]
        public Response AddSubject(Subject subject)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Con").ToString());
            Response response = new Response();

            DAL dal = new DAL();
            response = dal.AddSubjects(connection, subject);

            return response;
        }
    }
}
