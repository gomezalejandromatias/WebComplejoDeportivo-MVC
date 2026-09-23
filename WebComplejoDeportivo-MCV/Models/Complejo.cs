using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Complejo
    {
        // PK de Complejo
        public int Id { get; set; }

        // FK → Cliente al que pertenece este complejo
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        public string Telefono { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? LogoUrl { get; set; }

        public bool Activo { get; set; }


        // Navegación → Cliente
        public Cliente Cliente { get; set; } = null!;


        // Un complejo puede tener muchos usuarios
        public List<Usuario> Usuarios { get; set; } = new();

        // Un complejo puede tener muchas canchas
        public List<Cancha> Canchas { get; set; } = new();

        // Un complejo puede tener muchos socios
        public List<Socio> Socios { get; set; } = new();

        // Un complejo define sus tipos de socios
        public List<TipoSocio> TiposSocio { get; set; } = new();


    }
}
