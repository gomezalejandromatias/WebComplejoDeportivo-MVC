using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        // Persona que realiza la reserva.
        public int ReservanteId { get; set; }

        // Cancha elegida.
        public int CanchaId { get; set; }

        public DateOnly Fecha { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        // Conserva el precio acordado al reservar.
        public decimal Precio { get; set; }

        public EstadoReserva Estado { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public string? Observaciones { get; set; }


        // Cada reserva pertenece a un reservante.
        public Reservante Reservante { get; set; } = null!;


        // Cada reserva corresponde a una cancha.
        public Cancha Cancha { get; set; } = null!;


        // Una reserva puede tener varios pagos:
        // por ejemplo, una seña y después el saldo.
        public List<Pago> Pagos { get; set; } = new();




    }
}
