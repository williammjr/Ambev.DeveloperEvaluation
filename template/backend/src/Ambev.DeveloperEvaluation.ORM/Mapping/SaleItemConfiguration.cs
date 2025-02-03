using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.HasKey(si => new { si.SaleNumber, si.Product }); // Chave composta

            builder.Property(si => si.Quantity)
                .IsRequired(); // Definir como obrigatório

            builder.Property(si => si.UnitPrice)
                .HasColumnType("decimal(18,2)"); // Definir tipo decimal

            builder.Property(si => si.Discount)
                .HasColumnType("decimal(5,2)"); // Definir tipo decimal
        }
    }
}
