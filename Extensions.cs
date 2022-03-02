using HR_Management_Software.Dtos;
using HR_Management_Software.Models;

public static class Extensions
{
    public static EmployeeDto asDto(this Employee employee)
    {
        return new EmployeeDto
        {
            Id = employee.Id,
            Name = employee.Name,
            Position = employee.Position,
            HireDate = employee.HireDate,
            Birthday = employee.Birthday
        };
    }
}