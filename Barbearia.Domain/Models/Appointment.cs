using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barbearia.Domain.Models;

public class Appointment
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("Client")]
    public Guid ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public DateTime ScheduledAt { get; set; }

    public string? Notes { get; set; }

    public string Status { get; set; } = "Pending";

    public ICollection<AppointmentService> AppointmentServices { get; set; } = new List<AppointmentService>();
}
