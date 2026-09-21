namespace WebComplejoDeportivo_MCV.Models
{
    public class TipoCancha
    {

        public int Id { get; set; }

        // Ejemplos: Fútbol 5, Fútbol 7 o Fútbol 11.
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public int CantidadJugadores { get; set; }

        // Duración habitual de cada turno, expresada en minutos.
        public int DuracionTurnoMinutos { get; set; }


        // Un mismo tipo puede estar asignado a muchas canchas.
        public List<Cancha> Canchas { get; set; } = new();
    }
}
