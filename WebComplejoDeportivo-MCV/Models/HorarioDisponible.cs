namespace WebComplejoDeportivo_MCV.Models
{
    public class HorarioDisponible
    {

        // PK
        public int Id { get; set; }

        // FK → Cancha
        public int CanchaId { get; set; }

        // Enum de C#: lunes, martes, miércoles...
        public DayOfWeek DiaSemana { get; set; }

        public TimeSpan HoraDesde { get; set; }

        public TimeSpan HoraHasta { get; set; }

        // Duración del turno en minutos
        public int DuracionMinutos { get; set; }

        public bool Activo { get; set; }

        // Navegación → Cancha
        public Cancha Cancha { get; set; } = null!;





    }
}
