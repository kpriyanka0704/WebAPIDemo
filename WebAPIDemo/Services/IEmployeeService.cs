using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(int id);

    }
}
