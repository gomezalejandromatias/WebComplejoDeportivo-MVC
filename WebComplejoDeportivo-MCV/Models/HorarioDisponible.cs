namespace WebComplejoDeportivo_MCV.Models
{
    public class HorarioDisponible
    {

        public int Id { get; set; }

        // Cancha a la que pertenece este horario.
        public int CanchaId { get; set; }

        // DayOfWeek es un enum incluido en C#.
        public DayOfWeek DiaSemana { get; set; }

        public TimeSpan HoraDesde { get; set; }

        public TimeSpan HoraHasta { get; set; }

        // Duración permitida para cada turno.
        public int DuracionMinutos { get; set; }

        public bool Activo { get; set; }


        // Cada horario disponible pertenece a una cancha.
        public Cancha Cancha { get; set; } = null!;




    }
}
