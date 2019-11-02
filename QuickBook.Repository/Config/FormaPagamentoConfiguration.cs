using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Dominio.ObjetoDeValor;

namespace QuickBook.Repository.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.Nome)
                .HasMaxLength(20);

            builder
                .Property(d => d.Descricao)
                .HasMaxLength(200);
        }
    }
}
