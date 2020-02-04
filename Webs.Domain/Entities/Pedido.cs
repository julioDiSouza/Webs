using System;
using System.Collections.Generic;
using System.Text;

namespace Webs.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
    }
}
