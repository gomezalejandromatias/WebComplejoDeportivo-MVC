using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Plan
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        [Precision(12, 2)]
        public decimal PrecioMensual { get; set; }

        // Cantidad máxima de canchas permitidas por el plan
        public int MaximoCanchas { get; set; }

        // Indica si el plan permite administrar socios
        public bool HabilitaSocios { get; set; }

        // Duración de la demostración gratuita
        public int DiasPrueba { get; set; }

        public bool Activo { get; set; }

        // Un plan puede tener muchas suscripciones
        public List<Suscripcion> Suscripciones { get; set; } = new();

    }
}
