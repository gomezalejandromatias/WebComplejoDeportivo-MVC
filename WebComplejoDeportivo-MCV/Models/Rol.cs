using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Rol
    {
        // PK
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        public bool Activo { get; set; }


        // Un mismo rol puede asignarse a muchos usuarios
        public List<Usuario> Usuarios { get; set; } = new();

        // Un rol puede tener muchos permisos
        public List<Permiso> Permisos { get; set; } = new();

    }
}
