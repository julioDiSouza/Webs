using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Webs.Domain.Entities;

namespace Webs.Repository.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DataPedido).IsRequired();
            builder.Property(p => p.DataPrevisao).IsRequired();
            builder.Property(p => p.Cep).IsRequired();
            builder.Property(p => p.Estado).IsRequired();
            builder.Property(p => p.Cidade).IsRequired();
            builder.Property(p => p.Endereco).IsRequired();
            builder.Property(p => p.Numero).IsRequired();
            builder.Property(p => p.FormaPagamentoId).IsRequired();
        }
    }
}
