using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Reservante
    {
        // PK
        public int Id { get; set; }

        // FK → Usuario
        public string UsuarioId { get; set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        public string Telefono { get; set; } = string.Empty;

        // Cantidad de reservas a las que no asistió
        public int Inasistencias { get; set; }

        public bool Activo { get; set; }


        // Navegación → Usuario
        public Usuario Usuario { get; set; } = null!;

        // Un reservante puede realizar muchas reservas
        public List<Reserva> Reservas { get; set; } = new();


    }
}
