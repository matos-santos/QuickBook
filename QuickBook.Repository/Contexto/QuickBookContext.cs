﻿using Microsoft.EntityFrameworkCore;
using QuickBook.Dominio.Entidades;
using QuickBook.Dominio.ObjetoDeValor;
using QuickBook.Repository.Config;

namespace QuickBook.Repository.Contexto
{
    public class QuickBookContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento{ get; set; }

        public QuickBookContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao = "Forma de Pagamento Boleto" },
                new FormaPagamento() { Id = 2, Nome = "Cartão Crédito", Descricao = "Forma de Pagamento Cartão Crédito" },
                new FormaPagamento() { Id = 3, Nome = "Depósito", Descricao = "Forma de Pagamento Depósito" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
