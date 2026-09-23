using System.ComponentModel.DataAnnotations;
using WebComplejoDeportivo_MCV.Models.Enum;
namespace WebComplejoDeportivo_MCV.Models
{
    public class PagoTransferencia : Pago
    {
        [MaxLength(500)]
        public string? ComprobanteUrl { get; set; }

        [MaxLength(150)]
        public string? CuentaOrigen { get; set; }

        public DateTime? FechaValidacion { get; set; }

        // FK → empleado/administrador que validó
        public string? UsuarioValidadorId { get; set; }

        // Navegación → Usuario
        public Usuario? UsuarioValidador { get; set; }


        public override ResultadoPago ProcesarPago()
        {
            if (Importe <= 0)
            {
                Estado = EstadoPago.Rechazado;

                return ResultadoPago.Rechazado;
            }

            if (string.IsNullOrWhiteSpace(ComprobanteUrl))
            {
                Estado = EstadoPago.Pendiente;

                return ResultadoPago.Pendiente;
            }

            Estado = EstadoPago.Pendiente;

            return ResultadoPago.Pendiente;
        }


        public ResultadoPago ConfirmarTransferencia(int usuarioValidadorId)
        {
            UsuarioValidadorId = usuarioValidadorId;
            FechaValidacion = DateTime.Now;
            FechaConfirmacion = DateTime.Now;
            Estado = EstadoPago.Confirmado;

            return ResultadoPago.Exitoso;
        }
    }
}
