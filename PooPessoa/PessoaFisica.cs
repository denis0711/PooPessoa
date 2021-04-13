using System;


namespace PooPessoa
{
    class PessoaFisica : Pessoa
    {
        public string Rg { get; set; }

        

        public PessoaFisica(string nome, string rg) : base(nome)
        {
           
            Rg = rg;
        }

        public string getRg()
        {
            return Rg;
        }

        public void serRg(string rg)
        {
            this.Rg = rg;
        }
    }
}
