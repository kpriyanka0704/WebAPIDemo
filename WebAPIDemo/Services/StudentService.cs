using WebAPIDemo.Models;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }
        public int AddStudent(Student stud)
        {
            return _repo.AddStudent(stud);
        }
        public int DeleteStudent(int id)
        {
            return (_repo.DeleteStudent(id));
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _repo.GetAllStudents();
        }
        public Student GetStudentById(int id)
        {
            return _repo.GetStudentById(id);
        }

        public int UpdateStudent(Student stud)
        {
            return _repo.UpdateStudent(stud);
        }
    }
}
