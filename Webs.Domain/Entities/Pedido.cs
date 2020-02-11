using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Domain.ValueObjects;

namespace Webs.Domain.Entities
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimpaMensagens();

            if (!ItensPedidos.Any())
                AdicionarErro("Erro: Itens do pedido não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(Cep))
                AdicionarErro("Erro: CEP não pode ser vazio.");

            if (FormaPagamentoId == 0)
                AdicionarErro("Erro: É necessário indicar uma Forma de Pagamento.");
        }
    }
}
