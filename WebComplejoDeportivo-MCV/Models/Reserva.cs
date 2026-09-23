using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebComplejoDeportivo_MCV.Models.Enum;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Reserva
    {
        // PK
        public int Id { get; set; }

        // FK → persona que realiza la reserva
        public int ReservanteId { get; set; }

        // FK → cancha reservada
        public int CanchaId { get; set; }

        public DateOnly Fecha { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        // Precio acordado al momento de reservar
        [Precision(12, 2)]
        public decimal Precio { get; set; }

        public EstadoReserva Estado { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [MaxLength(500)]
        public string? Observaciones { get; set; }

        // Control de concurrencia
        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;


        // Navegación → Reservante
        public Reservante Reservante { get; set; } = null!;

        // Navegación → Cancha
        public Cancha Cancha { get; set; } = null!;

        // Una reserva puede tener varios pagos
        public List<Pago> Pagos { get; set; } = new();




    }
}
