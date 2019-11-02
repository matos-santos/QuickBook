using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Dominio.Entidades;

namespace QuickBook.Repository.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.ProdutoId)
                .IsRequired();

            builder
                .Property(d => d.Quantidade)
                .IsRequired();

        }
    }
}
