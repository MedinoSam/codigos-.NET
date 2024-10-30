using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    internal class CertidaoNascimento
    {
        public DateTime DataEmissao { get; private set; }
        public Pessoa Pessoa { get; private set; }

        public CertidaoNascimento(DateTime dataEmissao, Pessoa pessoa)
        {
            DataEmissao = dataEmissao;
            Pessoa = pessoa;
        }

    }
}
