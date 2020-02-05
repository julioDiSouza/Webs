using System;
using System.Collections.Generic;
using System.Text;

namespace Webs.Domain.Entities
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimpaMensagens();

            if (string.IsNullOrWhiteSpace(Email))
                AdicionarErro("Erro: Email não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(Senha))
                AdicionarErro("Erro: Senha não pode ser vazia.");
        }
    }
}