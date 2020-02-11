using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Webs.Domain.Entities;

namespace Webs.Repository.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProdutoId).IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
        }
    }
}
