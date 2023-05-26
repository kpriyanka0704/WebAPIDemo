using WebAPIDemo.Data;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public int AddStudent(Student stud)
        {
            _db.Students.Add(stud);
            int res = _db.SaveChanges();
            return res;
        }

        public int DeleteStudent(int id)
        {
            int res = 0;
            var stud = _db.Students.Find(id);
            if (stud != null)
            {
                _db.Students.Remove(stud);
                res = _db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _db.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            var stud = _db.Students.Find(id);
            return stud;
        }

        public int UpdateStudent(Student stud)
        {
            int res = 0;
            var s = _db.Students.Where(x => x.Id == stud.Id).FirstOrDefault();
            if (s != null)
            {
                s.Name = stud.Name;
                s.Percentage = stud.Percentage;
                s.Branch = stud.Branch;
                s.Email = stud.Email;
               
                res = _db.SaveChanges();
            }
            return res;
        }
    }
}
