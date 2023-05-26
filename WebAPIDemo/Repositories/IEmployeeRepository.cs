using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(int id);

    }
}
