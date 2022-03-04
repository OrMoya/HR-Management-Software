using System.ComponentModel.DataAnnotations;

public record UpdateEmployeeDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Position { get; set; }
    [Required]
    public DateTime Birthday { get; set; }
}