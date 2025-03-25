using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio8.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        //[Index(IsUnique = true)]
        public string Correo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "La contraseña debe tener al menos una mayúscula, un número y un carácter especial.")]
        public string Contraseña { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }
    }
}
