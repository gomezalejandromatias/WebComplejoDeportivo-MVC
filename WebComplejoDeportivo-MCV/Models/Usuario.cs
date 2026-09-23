using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Usuario : IdentityUser
    {
        // IdentityUser YA trae:
        // Id (string)
        // Email
        // UserName
        // PasswordHash
        // PhoneNumber
        // etc.


        // FK opcional → Complejo donde trabaja
        public int? ComplejoId { get; set; }

        // FK → Rol de tu sistema
        public int RolId { get; set; }


        // Identificador entregado por Google
        [MaxLength(200)]
        public string? GoogleSubject { get; set; }


        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;


        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; } = string.Empty;


        public bool Activo { get; set; }


        public DateTime? UltimoAcceso { get; set; }


        // Navegación → Complejo
        public Complejo? Complejo { get; set; }


        // Navegación → Rol
        public Rol Rol { get; set; } = null!;


        // Perfil utilizado cuando reserva canchas
        public Reservante? Reservante { get; set; }


        // Un usuario puede ser socio de uno o más complejos
        public List<Socio> Socios { get; set; } = new();


    }
}
