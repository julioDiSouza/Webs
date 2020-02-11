using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Webs.Domain.Entities
{
    public abstract class Entidade
    {
        [NotMapped]
        public List<string> _mensagensValidacao { get; set; }

        public abstract void Validate();

        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());  }
        }
        
        protected void LimpaMensagens()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarErro(string msg)
        {
            MensagemValidacao.Add(msg);
        }

        protected bool IsValido => !MensagemValidacao.Any();

    }
}
