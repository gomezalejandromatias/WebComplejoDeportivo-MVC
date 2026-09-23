using WebComplejoDeportivo_MCV.Models.Enum;
namespace WebComplejoDeportivo_MCV.Models
{
    public class PagoTransferencia : Pago
    {
        public string? ComprobanteUrl { get; set; }

        public string? CuentaOrigen { get; set; }

        public DateTime? FechaValidacion { get; set; }

        // Empleado o administrador que validó la transferencia.
        public int? UsuarioValidadorId { get; set; }


        public Usuario? UsuarioValidador { get; set; }


        public override ResultadoPago ProcesarPago()
        {
            if (Importe <= 0)
            {
                Estado = EstadoPago.Rechazado;

                return ResultadoPago.Rechazado;
            }

            // Sin comprobante no puede enviarse a validación.
            if (string.IsNullOrWhiteSpace(ComprobanteUrl))
            {
                Estado = EstadoPago.Pendiente;

                return ResultadoPago.Pendiente;
            }

            // El comprobante fue presentado, pero todavía
            // debe revisarlo una persona.
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
