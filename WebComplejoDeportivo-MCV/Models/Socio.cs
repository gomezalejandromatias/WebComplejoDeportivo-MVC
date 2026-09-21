namespace WebComplejoDeportivo_MCV.Models
{
    public class Socio
    {

        public int Id { get; set; }

        // Complejo al que pertenece.
        public int ComplejoId { get; set; }

        // Categoría asignada: activo, infantil, familiar, etc.
        public int TipoSocioId { get; set; }

        // Es opcional porque podría registrarse un socio
        // que todavía no ingresó al sistema con Google.
        public int? UsuarioId { get; set; }

        public string NumeroSocio { get; set; } = string.Empty;

        public DateTime FechaAlta { get; set; } = DateTime.Now;

        public EstadoSocio Estado { get; set; }

        public DateTime? FechaVencimiento { get; set; }


        // Cada socio pertenece a un complejo.
        public Complejo Complejo { get; set; } = null!;


        // Cada socio posee un solo tipo.
        public TipoSocio TipoSocio { get; set; } = null!;


        // Puede no tener usuario mientras no ingrese a la web.
        public Usuario? Usuario { get; set; }

    }
}
