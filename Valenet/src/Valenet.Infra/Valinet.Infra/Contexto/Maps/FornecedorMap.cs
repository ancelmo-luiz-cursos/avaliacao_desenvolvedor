using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Valinet.Dominio.Entidades;

namespace Valinet.Infra.Contexto.Maps
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(45).HasColumnType("varchar(45)");

            builder.HasMany(x => x.Produtos).WithOne(x => x.Fornecedor);
        }
    }
}
