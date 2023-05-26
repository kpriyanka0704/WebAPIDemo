using WebAPIDemo.Models;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public int AddEmployee(Employee emp)
        {
            return _repo.AddEmployee(emp);
        }
        public int DeleteEmployee(int id)
        {
            return (_repo.DeleteEmployee(id));
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _repo.GetAllEmployees();
        }
        public Employee GetEmployeeById(int id)
        {
            return _repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee emp)
        {
            return _repo.UpdateEmployee(emp);
        }
    }
}
