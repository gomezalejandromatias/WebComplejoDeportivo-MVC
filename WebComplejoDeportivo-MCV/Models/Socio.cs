using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebComplejoDeportivo_MCV.Models.Enum;
namespace WebComplejoDeportivo_MCV.Models
{
    public class Socio
    {
        // PK
        public int Id { get; set; }

        // FK → Complejo
        public int ComplejoId { get; set; }

        // FK → TipoSocio
        public int TipoSocioId { get; set; }

        // FK opcional → Usuario
        public string? UsuarioId { get; set; }

        [Required]
        [MaxLength(50)]
        public string NumeroSocio { get; set; } = string.Empty;

        public DateTime FechaAlta { get; set; } = DateTime.Now;

        public EstadoSocio Estado { get; set; }

        public DateTime? FechaVencimiento { get; set; }


        // Navegación → Complejo
        public Complejo Complejo { get; set; } = null!;

        // Navegación → TipoSocio
        [DeleteBehavior(DeleteBehavior.NoAction)]

        public TipoSocio TipoSocio { get; set; } = null!;

        // Navegación opcional → Usuario
        public Usuario? Usuario { get; set; }

    }
}
