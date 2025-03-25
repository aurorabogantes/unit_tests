using Laboratorio8.Models;

namespace Laboratorio8.ReglasDeNegocio
{
    public static class ReglasDePedido
    {
        public static bool EsValido(Pedido pedido)
        {
            if(pedido == null) return false;

            if(pedido.IdPedido <= 0) return false;

            if(pedido.IdUsuario <= 0) return false;

            if(pedido.FechaPedido > DateTime.Now) return false;

            if (string.IsNullOrEmpty(pedido.Estado) || !(pedido.Estado == "pendiente" || pedido.Estado == "enviado" || pedido.Estado == "entregado"))
                return false;

            return true;
        }
    }
}
