namespace WebComplejoDeportivo_MCV.Models
{
    public class Reservante
    {
        public int Id { get; set; }

        // Usuario que ingresó, por ejemplo, mediante Google.
        public int UsuarioId { get; set; }

        public string Telefono { get; set; } = string.Empty;

        // Permite registrar cuántas veces reservó y no asistió.
        public int Inasistencias { get; set; }

        public bool Activo { get; set; }


        // Cada reservante corresponde a un usuario del sistema.
        public Usuario Usuario { get; set; } = null!;


        // Un reservante puede realizar muchas reservas.
        public List<Reserva> Reservas { get; set; } = new();


    }
}
