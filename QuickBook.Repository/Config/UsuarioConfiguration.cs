using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBook.Dominio.Entidades;

namespace QuickBook.Repository.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(d => d.SobreNome)
                .HasMaxLength(50);

            builder
                .Property(d => d.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .HasMany(d => d.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
