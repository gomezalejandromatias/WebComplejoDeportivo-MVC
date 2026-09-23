
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebComplejoDeportivo_MCV.Models.Enum;

namespace WebComplejoDeportivo_MCV.Models

{
    public abstract class Pago
    {

        public int Id { get; set; }

        // FK → Reserva que se está pagando
        public int ReservaId { get; set; }

        [Precision(12, 2)]
        public decimal Importe { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public DateTime? FechaConfirmacion { get; set; }

        public EstadoPago Estado { get; set; }

        // Identificador proporcionado por banco/plataforma externa
        [MaxLength(200)]
        public string? ReferenciaExterna { get; set; }

        // Navegación → Reserva
        public Reserva Reserva { get; set; } = null!;

        // Cada clase hija procesa el pago de manera diferente
        public abstract ResultadoPago ProcesarPago();
    }
}
