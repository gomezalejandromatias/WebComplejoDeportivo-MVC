using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Permiso
    {

        // PK
        public int Id { get; set; }

        // Ejemplo: VER_CAJA
        [Required]
        [MaxLength(100)]
        public string Codigo { get; set; } = string.Empty;

        // Ejemplo: Ver caja
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        // Un permiso puede pertenecer a varios roles
        public List<Rol> Roles { get; set; } = new();

    }
}
