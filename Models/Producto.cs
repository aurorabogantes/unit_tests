using System.ComponentModel.DataAnnotations;

namespace Laboratorio8.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Nombre { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }

        [Required]
        public int? Stock { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
