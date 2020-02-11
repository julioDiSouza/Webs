using System;
using System.Collections.Generic;
using System.Text;
using Webs.Domain.Contracts;
using Webs.Domain.Entities;
using Webs.Repository.Contexto;

namespace Webs.Repository.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(WebsContexto websContexto) : base(websContexto)
        {

        }
    }
}
