using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class TipoSocio
    {

        // PK
        public int Id { get; set; }

        // FK → Complejo
        public int ComplejoId { get; set; }

        // Ejemplos: Infantil, Activo, Familiar, Vitalicio
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        [Precision(12, 2)]
        public decimal CuotaMensual { get; set; }

        [MaxLength(1000)]
        public string? Beneficios { get; set; }

        public bool Activo { get; set; }


        // Navegación → Complejo
        public Complejo Complejo { get; set; } = null!;

        // Un tipo puede estar asignado a muchos socios
        public List<Socio> Socios { get; set; } = new();

    }
}
