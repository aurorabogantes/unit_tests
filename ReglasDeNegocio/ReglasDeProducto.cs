using System.ComponentModel.DataAnnotations;
using Laboratorio8.Models;

namespace Laboratorio8.ReglasDeNegocio
{
    public static class ReglasDeProducto
    {
        public static bool EsValido(Producto producto, List<Producto> productosExistentes)
        {
            if(producto == null) return false;
             
            if(producto.IdProducto <= 0) return false;

            if (productosExistentes.Any(p => p.IdProducto == producto.IdProducto))
                return false;

            if (string.IsNullOrEmpty(producto.Nombre) || producto.Nombre.Length < 2 || producto.Nombre.Length > 50)
                return false;

            if(producto.Precio <= 0) return false;


            if(producto.Stock <= 0) return false;

            if (producto.FechaCreacion == default)
                return false;

            return true;
        }
    }
}
