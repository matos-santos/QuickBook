using System.Collections.Generic;

namespace QuickBook.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string SobreNome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Não fooi informado nome do usuario");

            if (string.IsNullOrEmpty(Email))
                AdicionarMensagem("Não foi informado o email do usuario");
        }
    }
}
