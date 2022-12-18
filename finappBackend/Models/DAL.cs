using ASPNETCoreApplication.Models;
using System.Data;
using System.Data.SqlClient;

namespace finappBackend.Models
{
    public class DAL
    {
        //Data Access Layer

        //students

        public Response GetAllStudents(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from dbo.student", connection);
            DataTable dt = new DataTable();
            List<Student> lstStudents = new List<Student>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Student student = new Student();

                    student.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    student.firstName = Convert.ToString(dt.Rows[i]["firstName"]);
                    student.lastName = Convert.ToString(dt.Rows[i]["lastName"]);
                    student.contactPerson = Convert.ToString(dt.Rows[i]["contactPerson"]);
                    student.emailAddress = Convert.ToString(dt.Rows[i]["emailAddress"]);
                    student.contactNo = Convert.ToString(dt.Rows[i]["contactNo"]);
                    student.dob = Convert.ToString(dt.Rows[i]["dob"]);
                    student.classRoom = Convert.ToString(dt.Rows[i]["classRoom"]);
                    student.age = Convert.ToInt32(dt.Rows[i]["age"]);

                    lstStudents.Add(student);

                }
            }
            if (lstStudents.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data Found";
                response.listStudents = lstStudents;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data Found";
                response.listStudents = null;
            }

            return response;

        }

        public Response AddStudent(SqlConnection connection, Student student )
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO student(firstName,lastName,contactPerson,emailAddress,contactNo,dob,age,classRoom) VALUES" +
                "('" + student.firstName + "','" + student.lastName + "','" + student.contactPerson + "'," +
                "'" + student.emailAddress + "','" + student.contactNo + "','" + student.dob + "'," +
                "'" + student.age + "','" + student.classRoom+ "' )", connection);

            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            if (i > 0)
            {

                response.StatusCode = 200;
                response.StatusMessage = "Student added";

            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data inserted";
            }

            return response;

        }

        //Classroom

        public Response GetAllClassrooms(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from dbo.classroom", connection);
            DataTable dt = new DataTable();
            List<Classroom> lstClassrooms = new List<Classroom>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Classroom classroom = new Classroom();
                    classroom.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    classroom.classroomName = Convert.ToString(dt.Rows[i]["classroomName"]);

                    lstClassrooms.Add(classroom);

                }
            }
            if (lstClassrooms.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data Found";
                response.listClassrooms = lstClassrooms;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data Found";
                response.listClassrooms = null;
            }

            return response;

        }

        public Response AddClassroom(SqlConnection connection, Classroom classroom)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO classroom(classroomName) VALUES" +
                "('" + classroom.classroomName + "' )", connection);

            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            if (i > 0)
            {

                response.StatusCode = 200;
                response.StatusMessage = "Classroom added";

            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data inserted";
            }

            return response;

        }

        //Subject
        public Response GetAllSubjects(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from dbo.subject", connection);
            DataTable dt = new DataTable();
            List<Subject> lstSubjects = new List<Subject>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Subject subject = new Subject();
                    subject.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    subject.subjectName = Convert.ToString(dt.Rows[i]["subjectName"]);

                    lstSubjects.Add(subject);

                }
            }
            if (lstSubjects.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data Found";
                response.listSubjects = lstSubjects;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data Found";
                response.listSubjects = null;
            }

            return response;

        }

        public Response AddSubjects(SqlConnection connection, Subject subject)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO subject(subjectName) VALUES" +
                "('" + subject.subjectName + "' )", connection);

            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            if (i > 0)
            {

                response.StatusCode = 200;
                response.StatusMessage = "Subject added";

            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data inserted";
            }

            return response;

        }

        //Teacher

        public Response GetAllTeachers(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from dbo.teacher", connection);
            DataTable dt = new DataTable();
            List<Teacher> lstTeachers = new List<Teacher>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Teacher teacher = new Teacher();

                    teacher.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    teacher.firstName = Convert.ToString(dt.Rows[i]["firstName"]);
                    teacher.lastName = Convert.ToString(dt.Rows[i]["lastName"]);
                    teacher.emailAddress = Convert.ToString(dt.Rows[i]["emailAddress"]);
                    teacher.contactNo = Convert.ToString(dt.Rows[i]["contactNo"]);
                    teacher.classRooms = Convert.ToString(dt.Rows[i]["classRooms"]);
                    teacher.subjects = Convert.ToString(dt.Rows[i]["subjects"]);

                    lstTeachers.Add(teacher);

                }
            }
            if (lstTeachers.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data Found";
                response.listTeachers = lstTeachers;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data Found";
                response.listTeachers = null;
            }

            return response;

        }

        public Response AddTeacher(SqlConnection connection, Teacher teacher)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand
                ("INSERT INTO teacher(firstName,lastName,emailAddress,contactNo,classRooms,subjects) VALUES" +
                "('" + teacher.firstName + "','" + teacher.lastName + "','" + teacher.emailAddress + "'," +
                "'" + teacher.contactNo + "','" + teacher.classRooms + "','" + teacher.subjects + "' )", connection);

            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            if (i > 0)
            {

                response.StatusCode = 200;
                response.StatusMessage = "Teacher added";

            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data inserted";
            }

            return response;

        }


    }
}
