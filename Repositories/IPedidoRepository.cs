using SaborDeCasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaborDeCasa.Repositories
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
