using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Webs.Domain.Entities;
using Webs.Domain.ValueObjects;

namespace Webs.Repository.Contexto
{
    public class WebsContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public WebsContexto(DbContextOptions options) : base(options)
        {

        }
    }
}
