using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Barbearia.Infrastructure.Models;

namespace Barbearia.Infrastructure.Models
{
    public class AppointmentService
    { 
        public Guid AppointmentId { get; set; }     
        public Appointment Appointment { get; set; } = null!;
        public Guid ServiceId { get; set; }
    }
}