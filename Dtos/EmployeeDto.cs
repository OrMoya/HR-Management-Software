namespace HR_Management_Software.Dtos
{
    public record EmployeeDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Position { get; set; }
        public DateTime HireDate { get; init; }
        public DateTime Birthday { get; init; }
    }
}