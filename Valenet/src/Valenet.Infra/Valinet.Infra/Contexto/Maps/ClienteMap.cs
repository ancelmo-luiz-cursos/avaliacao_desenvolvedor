using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Valinet.Dominio.Entidades;

namespace Valinet.Infra.Contexto.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.Endereco).HasMaxLength(100).HasColumnType("varchar(100)");

            builder.HasMany(x => x.Pedidos).WithOne(x => x.Cliente);
        }
    }
}
