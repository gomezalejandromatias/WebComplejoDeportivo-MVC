namespace WebComplejoDeportivo_MCV.Models
{
    public class Cancha
    {

        public int Id { get; set; }

        // Complejo al que pertenece la cancha.
        public int ComplejoId { get; set; }

        // Tipo de cancha: fútbol 5, 7, 11, etc.
        public int TipoCanchaId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public decimal PrecioTurno { get; set; }

        public string? FotoUrl { get; set; }

        public bool Activa { get; set; }


        // Cada cancha pertenece a un complejo.
        public Complejo Complejo { get; set; } = null!;


        // Cada cancha tiene un solo tipo.
        public TipoCancha TipoCancha { get; set; } = null!;


        // Una cancha puede configurar diferentes horarios.
        public List<HorarioDisponible> HorariosDisponibles { get; set; } = new();


        // Una cancha puede recibir muchas reservas.
        public List<Reserva> Reservas { get; set; } = new();


    }
}
