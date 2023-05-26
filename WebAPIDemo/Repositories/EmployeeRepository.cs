using WebAPIDemo.Data;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public int AddEmployee(Employee emp)
        {
            _db.Employees.Add(emp);
            int res = _db.SaveChanges();
            return res;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var emp = _db.Employees.Find(id);
            if (emp != null)
            {
                _db.Employees.Remove(emp);
                res = _db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = _db.Employees.Find(id);
            return emp;
        }

        public int UpdateEmployee(Employee emp)
        {
            int res = 0;
            var e = _db.Employees.Where(x => x.Id == emp.Id).FirstOrDefault();
            if (e != null)
            {
                e.Name = emp.Name;
                e.Salary = emp.Salary;
                e.City = emp.City;
                res = _db.SaveChanges();
            }
            return res;
        }

    }
}
