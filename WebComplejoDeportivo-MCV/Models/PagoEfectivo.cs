using System.ComponentModel.DataAnnotations;
using WebComplejoDeportivo_MCV.Models.Enum;
namespace WebComplejoDeportivo_MCV.Models
{
    public class PagoEfectivo : Pago
    {
        // FK → Usuario que recibió el dinero
        public string? UsuarioCobradorId { get; set; }

        public DateTime? FechaCobro { get; set; }

        [MaxLength(500)]
        public string? Observacion { get; set; }

        // Navegación → Usuario que registró el cobro
        public Usuario? UsuarioCobrador { get; set; }


        public override ResultadoPago ProcesarPago()
        {
            if (Importe <= 0)
            {
                Estado = EstadoPago.Rechazado;

                return ResultadoPago.Rechazado;
            }

            FechaCobro = DateTime.Now;
            FechaConfirmacion = DateTime.Now;
            Estado = EstadoPago.Confirmado;

            return ResultadoPago.Exitoso;
        }
    }
}
