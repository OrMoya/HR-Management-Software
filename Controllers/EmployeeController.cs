using HR_Management_Software.Dtos;
using HR_Management_Software.Models;
using HR_Management_Software.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_Software.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<List<EmployeeDto>> GetEmployees()
        {
            var employees = new List<EmployeeDto>();

            foreach(var e in repository.GetEmployees())
            {
                employees.Add(e.asDto());
            }

            return employees;
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeDto> GetEmployee(Guid id)
        {
            var employee = repository.GetEmployee(id);

            if(employee is null)
                return NotFound();
            
            return employee.asDto();
        }

        [HttpPost]
        public ActionResult<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto employeeDto)
        {
            Employee employee = new()
            {
                Id = Guid.NewGuid(),
                Name = employeeDto.Name, 
                Position = employeeDto.Position, 
                HireDate = DateTime.UtcNow,
                Birthday = employeeDto.Birthday
            };

            repository.CreateEmployee(employee);

            return CreatedAtAction(nameof(GetEmployee), new {id = employee.Id}, employee.asDto());
        }

        [HttpDelete("{id}")]
        public ActionResult<EmployeeDto> DeleteEmployee(Guid id)
        {
            repository.DeleteEmloyee(id);
            return NoContent();
        }
    }
}