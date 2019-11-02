using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Dominio.Entidades;

namespace QuickBook.Repository.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.Descricao)
                .HasMaxLength(2048);

            builder
                .Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(d => d.Preco)
                .IsRequired();
        }
    }
}
