using System.ComponentModel.DataAnnotations;

namespace Laboratorio8.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [Required]
        public DateTime FechaPedido { get; set; }

        [Required]
        [RegularExpression(@"^pendiente$|^enviado$|entregado$", ErrorMessage = "Estado inválido.")]
        public string Estado { get; set; }
    }
}
