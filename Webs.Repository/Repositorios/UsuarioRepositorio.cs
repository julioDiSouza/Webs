using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Domain.Contracts;
using Webs.Domain.Entities;
using Webs.Repository.Contexto;

namespace Webs.Repository.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(WebsContexto websContexto) : base(websContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return WebsContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
