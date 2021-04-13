using System;


namespace PooPessoa
{
    class Funcionario : PessoaFisica
    {
        public string Cartao { get; set; }

     

        public Funcionario( string nome, string rg, string cartao) : base(nome,rg )
        {
            Cartao = cartao;
        }

        public string  getCartao()
        {
            return Cartao;
        }

        public void setCartao(string cartao)
        {
            this.Cartao = cartao;
        }


    }
}
