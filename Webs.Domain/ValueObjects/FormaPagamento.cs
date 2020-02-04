using System;
using System.Collections.Generic;
using System.Text;
using Webs.Domain.Enums;

namespace Webs.Domain.ValueObjects
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto => Id == (int)TipoFormaPagamento.Boleto;
        public bool IsNaoDefinido => Id == (int)TipoFormaPagamento.NaoDefinido;
        public bool IsCartaoCredito => Id == (int)TipoFormaPagamento.CartaoCredito;
        public bool IsDeposito => Id == (int)TipoFormaPagamento.Deposito;
    }
}