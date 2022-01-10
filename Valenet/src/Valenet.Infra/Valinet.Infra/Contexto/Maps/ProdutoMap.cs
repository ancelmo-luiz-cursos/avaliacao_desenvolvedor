using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Valinet.Dominio.Entidades;

namespace Valinet.Infra.Contexto.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.Preco).IsRequired().HasColumnType("decimal(18, 2)");
           
        }
    }
}
