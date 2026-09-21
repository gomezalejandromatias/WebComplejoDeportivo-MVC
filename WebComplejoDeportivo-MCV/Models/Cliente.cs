using System.Numerics;

namespace WebComplejoDeportivo_MCV.Models
{
    public class Cliente
    {

        public int Id { get; set; }

        public string NombreORazonSocial { get; set; } = string.Empty;

        public string? Cuit { get; set; }

        public string EmailContacto { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public bool Activo { get; set; }


        // Un cliente administra un complejo.
        public Complejo? Complejo { get; set; }


        // Un cliente puede contratar distintas suscripciones
        // a lo largo del tiempo.
        public List<Suscripcion> Suscripciones { get; set; } = new();





    }
}
