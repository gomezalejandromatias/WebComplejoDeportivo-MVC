namespace WebComplejoDeportivo_MCV.Models
{
    public class TipoSocio
    {

        public int Id { get; set; }

        // Cada complejo configura sus propios tipos de socio.
        public int ComplejoId { get; set; }

        // Ejemplos: Infantil, Activo, Familiar o Vitalicio.
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public decimal CuotaMensual { get; set; }

        public string? Beneficios { get; set; }

        public bool Activo { get; set; }


        // El tipo de socio pertenece a un complejo.
        public Complejo Complejo { get; set; } = null!;


        // Un mismo tipo puede asignarse a muchos socios.
        public List<Socio> Socios { get; set; } = new();

    }
}
