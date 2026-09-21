namespace WebComplejoDeportivo_MCV.Models
{
    public class Suscripcion
    {
        public int Id { get; set; }

        // Cliente que contrató la suscripción.
        public int ClienteId { get; set; }

        // Plan contratado.
        public int PlanId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public EstadoSuscripcion Estado { get; set; }

        // Conserva el precio que se acordó al contratarlo.
        public decimal PrecioContratado { get; set; }

        public bool RenovacionAutomatica { get; set; }


        // Una suscripción pertenece a un cliente.
        public Cliente Cliente { get; set; } = null!;


        // Una suscripción corresponde a un plan.
        public Plan Plan { get; set; } = null!;


    }
}
