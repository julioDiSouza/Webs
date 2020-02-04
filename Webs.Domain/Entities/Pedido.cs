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
        public DateTime DataPrevisao { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }

        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
