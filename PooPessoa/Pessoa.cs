using System;


namespace PooPessoa
{
    class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa (string nome) 
        {
            Nome = nome;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
    }
}
