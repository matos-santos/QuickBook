using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Dominio.Entidades;
using System;

namespace QuickBook.Repository.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.NumeroEndereco)
                .HasMaxLength(3);

            builder
                .Property(d => d.CEP)
                .HasMaxLength(9);

            builder
                .Property(d => d.Cidade)
                .HasMaxLength(50);

            builder
                .Property(d => d.EnderecoCompleto)
                .HasMaxLength(200);

            builder
                .Property(d => d.Estado)
                .HasMaxLength(10);

            builder
                .Property(d => d.DataPedido)
                .IsRequired();

            builder
                .Property(d => d.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .HasOne(p => p.FormaPagamento);

        }
    }
}
