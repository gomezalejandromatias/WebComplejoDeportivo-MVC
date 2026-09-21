namespace WebComplejoDeportivo_MCV.Models
{
    public class PagoEfectivo : Pago
    {
        // Usuario empleado o administrador que recibió el dinero.
        public int? UsuarioCobradorId { get; set; }

        public DateTime? FechaCobro { get; set; }

        public string? Observacion { get; set; }


        // Usuario que registró el cobro.
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
