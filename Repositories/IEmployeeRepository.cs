using HR_Management_Software.Models;

namespace HR_Management_Software.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(Guid id);
        IEnumerable<Employee> GetEmployees();
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmloyee(Guid id);
    }
}