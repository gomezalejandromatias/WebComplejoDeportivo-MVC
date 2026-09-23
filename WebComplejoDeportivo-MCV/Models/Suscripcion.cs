using Microsoft.EntityFrameworkCore;
using WebComplejoDeportivo_MCV.Models.Enum;
namespace WebComplejoDeportivo_MCV.Models
{
    public class Suscripcion
    {
        // PK
        public int Id { get; set; }

        // FK → Cliente
        public int ClienteId { get; set; }

        // FK → Plan
        public int PlanId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public EstadoSuscripcion Estado { get; set; }

        // Precio acordado al momento de contratar
        [Precision(12, 2)]
        public decimal PrecioContratado { get; set; }

        public bool RenovacionAutomatica { get; set; }


        // Navegación → Cliente
        public Cliente Cliente { get; set; } = null!;

        // Navegación → Plan
        public Plan Plan { get; set; } = null!;


    }
}
