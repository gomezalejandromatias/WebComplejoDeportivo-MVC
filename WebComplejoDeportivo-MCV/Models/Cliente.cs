using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Cliente
    {

        // PK de Cliente
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string NombreORazonSocial { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? Cuit { get; set; }

        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string EmailContacto { get; set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        public string Telefono { get; set; } = string.Empty;

        public bool Activo { get; set; }

        // Navegación → un cliente administra un complejo
        public Complejo? Complejo { get; set; }

        // Un cliente puede tener varias suscripciones
        public List<Suscripcion> Suscripciones { get; set; } = new();





    }
}
