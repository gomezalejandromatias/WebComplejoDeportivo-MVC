namespace WebComplejoDeportivo_MCV.Models
{
    public class Permiso
    {

        public int Id { get; set; }

        // Nombre interno utilizado por el sistema.
        // Ejemplo: VER_CAJA
        public string Codigo { get; set; } = string.Empty;

        // Nombre que podrá mostrarse en pantalla.
        // Ejemplo: Ver caja
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }


        // Un permiso puede estar incluido en diferentes roles.
        public List<Rol> Roles { get; set; } = new();


    }
}
