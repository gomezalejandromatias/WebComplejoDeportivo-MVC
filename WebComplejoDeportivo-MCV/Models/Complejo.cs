namespace WebComplejoDeportivo_MCV.Models
{
    public class Complejo
    {
        public int Id { get; set; }

        // Relación con el cliente que contrató la plataforma.
        public int ClienteId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string? LogoUrl { get; set; }

        public bool Activo { get; set; }


        // Un complejo pertenece a un cliente.
        public Cliente Cliente { get; set; } = null!;


        // Un complejo puede tener muchos usuarios.
        public List<Usuario> Usuarios { get; set; } = new();


        // Un complejo puede tener muchas canchas.
        public List<Cancha> Canchas { get; set; } = new();


        // Un complejo puede tener muchos socios.
        public List<Socio> Socios { get; set; } = new();


        // El complejo define sus propios tipos de socios.
        public List<TipoSocio> TiposSocio { get; set; } = new();


    }
}
