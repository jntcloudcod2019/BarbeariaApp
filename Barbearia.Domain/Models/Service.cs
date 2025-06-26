using System.ComponentModel.DataAnnotations;

namespace Barberia.Domain.Models
{
    public class Service
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public decimal Price { get; set; }

    public int DurationInMinutes { get; set; }
}
}