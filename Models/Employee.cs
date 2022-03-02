namespace HR_Management_Software.Models
{
    public record Employee
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Position { get; set; }
        public DateTime HireDate { get; init; }
        public DateTime Birthday { get; init; }

    }
}
