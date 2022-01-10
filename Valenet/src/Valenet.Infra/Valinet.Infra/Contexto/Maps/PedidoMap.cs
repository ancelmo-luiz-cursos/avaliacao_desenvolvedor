using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Valinet.Dominio.Entidades;

namespace Valinet.Infra.Contexto.Maps
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade).IsRequired().HasColumnType("int");


        }
    }
}
