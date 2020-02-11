using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webs.Domain.Contracts;
using Webs.Repository.Contexto;

namespace Webs.Repository.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly WebsContexto WebsContexto;

        public BaseRepositorio(WebsContexto websContexto)
        {
            this.WebsContexto = websContexto;
        }
        
        public void Adicionar(TEntity entity)
        {
            WebsContexto.Set<TEntity>().Add(entity);
            WebsContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            WebsContexto.Set<TEntity>().Update(entity);
            WebsContexto.SaveChanges();
        }
        
        public TEntity ObterPorId(int id)
        {
            return WebsContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return WebsContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            WebsContexto.Remove(entity);
            WebsContexto.SaveChanges();
        }

        public void Dispose()
        {
            WebsContexto.Dispose();
        }
    }
}
