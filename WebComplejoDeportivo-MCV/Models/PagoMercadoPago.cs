using WebComplejoDeportivo_MCV.Models.Enum;
namespace WebComplejoDeportivo_MCV.Models
{
    public class PagoMercadoPago : Pago
    {
        // Identificador entregado por Mercado Pago.
        public string? IdPagoProveedor { get; set; }

        // Enlace que utilizará el cliente para pagar.
        public string? LinkPago { get; set; }

        // Estado informado por Mercado Pago.
        public string? EstadoProveedor { get; set; }


        public override ResultadoPago ProcesarPago()
        {
            if (Importe <= 0)
            {
                Estado = EstadoPago.Rechazado;

                return ResultadoPago.Rechazado;
            }

            // El pago se inicia, pero todavía debe ser
            // confirmado por Mercado Pago.
            Estado = EstadoPago.Pendiente;
            EstadoProveedor = "pending";

            return ResultadoPago.Pendiente;
        }


        public ResultadoPago ConfirmarDesdeProveedor(
            string idPagoProveedor,
            string estadoProveedor)
        {
            IdPagoProveedor = idPagoProveedor;
            EstadoProveedor = estadoProveedor;
            ReferenciaExterna = idPagoProveedor;

            if (estadoProveedor == "approved")
            {
                Estado = EstadoPago.Confirmado;
                FechaConfirmacion = DateTime.Now;

                return ResultadoPago.Exitoso;
            }

            if (estadoProveedor == "rejected")
            {
                Estado = EstadoPago.Rechazado;

                return ResultadoPago.Rechazado;
            }

            Estado = EstadoPago.Pendiente;

            return ResultadoPago.Pendiente;
        }
    }
}
