
using WebComplejoDeportivo_MCV.Models.Enum;

namespace WebComplejoDeportivo_MCV.Models

{
    public abstract class Pago
    {

        public int Id { get; set; }

        // Reserva que se está pagando.
        public int ReservaId { get; set; }

        public decimal Importe { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public DateTime? FechaConfirmacion { get; set; }

        public EstadoPago Estado { get; set; }

        // Identificador proporcionado por un banco
        // o una plataforma externa.
        public string? ReferenciaExterna { get; set; }


        // Cada pago corresponde a una reserva.
        public Reserva Reserva { get; set; } = null!;


        // Cada clase hija procesará el pago de manera diferente.
        public abstract ResultadoPago ProcesarPago();
    }
}
