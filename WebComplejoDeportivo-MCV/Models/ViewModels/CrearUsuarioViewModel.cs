using System.ComponentModel.DataAnnotations;

namespace WebComplejoDeportivo_MCV.Models.ViewModels
{
    public class CrearUsuarioViewModel
    {

        public int id { get; set; }

        [Required]
        public string Nombre { get; set; } = "";

        [Required]
        public string Apellido { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";

        [Required]
        public int RolId { get; set; }

        public int? ComplejoId { get; set; }

        public bool Activo { get; set; } = true;




    }
}
