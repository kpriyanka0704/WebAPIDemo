using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        int AddStudent(Student stud);
        int UpdateStudent(Student stud);
        int DeleteStudent(int id);
    }
}
