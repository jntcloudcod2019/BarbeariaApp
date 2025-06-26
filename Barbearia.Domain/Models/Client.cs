using System.ComponentModel.DataAnnotations;
using Barbearia.Domain.Models;


namespace Barbearia.Domain.Models
{
    public class Clients
    {
        [Key]
        public Guid ClientID { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public string Cpf { get; set; }

        public string Sex { get; set; }

        [Required]
        public string WhattsApp { get; set; }

        public string Email { get; set; }

        public string PhoneSecondary { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
              
    }
}