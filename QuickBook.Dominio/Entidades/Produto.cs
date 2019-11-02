using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBook.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string  Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (Preco == 0)
                AdicionarMensagem("Não foi informado o valor do produto");

            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Não foi informado um nome de produto");
        }
    }
}
