using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Webs.Domain.Entities;
using Webs.Domain.ValueObjects;
using Webs.Repository.Config;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Pagamento por Boleto"
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartão de Crédito",
                    Descricao = "Pagamento por Cartão de Crédito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descricao = "Pagamento por Depósito"
                }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
