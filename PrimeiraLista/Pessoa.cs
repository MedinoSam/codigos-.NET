using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    internal class Pessoa
    {
        public string Nome {  get; private set; }
        public CertidaoNascimento Certidao { get; private set; }

        public Pessoa(string nome, CertidaoNascimento certidao = null)
        {
            Nome = nome;
            Certidao = certidao;
        }
    }
}
