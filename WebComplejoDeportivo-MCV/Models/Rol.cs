namespace WebComplejoDeportivo_MCV.Models
{
    public class Rol
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public bool Activo { get; set; }


        // Un mismo rol puede asignarse a muchos usuarios.
        public List<Usuario> Usuarios { get; set; } = new();


        // Un rol puede tener muchos permisos.
        public List<Permiso> Permisos { get; set; } = new();


    }
}
