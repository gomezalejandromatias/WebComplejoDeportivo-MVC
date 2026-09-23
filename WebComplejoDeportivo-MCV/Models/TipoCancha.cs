using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class TipoCancha
    {

        // PK
        public int Id { get; set; }

        // Ejemplos: Fútbol 5, Fútbol 7, Fútbol 11
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        public int CantidadJugadores { get; set; }

        // Duración habitual del turno en minutos
        public int DuracionTurnoMinutos { get; set; }

        // Un mismo tipo puede estar asignado a muchas canchas
        public List<Cancha> Canchas { get; set; } = new();
    }
}
