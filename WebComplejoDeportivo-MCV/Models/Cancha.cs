using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Cancha
    {

        // PK de Cancha
        public int Id { get; set; }

        // FK → complejo al que pertenece
        public int ComplejoId { get; set; }

        // FK → tipo de cancha (F5, F7, F11...)
        public int TipoCanchaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        [Precision(10, 2)]
        public decimal PrecioTurno { get; set; }

        [MaxLength(500)]
        public string? FotoUrl { get; set; }

        public bool Activa { get; set; }

        // Navegaciones
        public Complejo Complejo { get; set; } = null!;

        public TipoCancha TipoCancha { get; set; } = null!;

        public List<HorarioDisponible> HorariosDisponibles { get; set; } = new();

        public List<Reserva> Reservas { get; set; } = new();


    }
}
