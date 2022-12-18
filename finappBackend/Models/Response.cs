
using finappBackend.Models;

namespace ASPNETCoreApplication.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public Employee Employee { get; set; }

        public Student student { get; set; }

        public Classroom classroom { get; set; }

        public Subject subject { get; set; }

        public Teacher teacher { get; set; }


        public List<Employee> listEmployees { get; set;}
        public List<Student> listStudents { get; set; }

        public List<Classroom> listClassrooms { get; set; }

        public List<Subject> listSubjects { get; set; }

        public List<Teacher> listTeachers { get; set; }




    }
}