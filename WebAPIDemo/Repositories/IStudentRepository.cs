using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        int AddStudent(Student stud);
        int UpdateStudent(Student stud);
        int DeleteStudent(int id);
    }
}

