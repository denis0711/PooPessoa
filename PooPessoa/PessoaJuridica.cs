using System;


namespace PooPessoa
{
    class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public PessoaJuridica(string nome, string cnpj) : base(nome)
        {
            Cnpj = cnpj;
        }

        public void setCnpj(string cnpj) 
        {
            this.Cnpj = cnpj;
        }

        public string getCnpj()
        {
            return Cnpj;
        }

    }
}
