using Microsoft.AspNetCore.Identity;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Usuario : IdentityUser
    {
        public int Id { get; set; }

        // Es opcional porque un reservante no trabaja
        // necesariamente para un complejo.
        public int? ComplejoId { get; set; }

        public int RolId { get; set; }

        // Identificador único entregado por Google.
        public string? GoogleSubject { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public bool Activo { get; set; }

        public DateTime? UltimoAcceso { get; set; }


        // Complejo en el que trabaja, si es dueño o empleado.
        public Complejo? Complejo { get; set; }


        // Cada usuario tiene un solo rol.
        public Rol Rol { get; set; } = null!;


        // Perfil utilizado cuando reserva canchas.
        public Reservante? Reservante { get; set; }


        // Un usuario podría ser socio de uno o más complejos.
        public List<Socio> Socios { get; set; } = new();



    }
}
