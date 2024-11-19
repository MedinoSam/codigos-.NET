using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Conversor
    {
        public string Origem {  get; private set; }
        public string Destino { get; private set; }
        public float Valor { get; private set; }
        public Conversor(string origem, string destino, float valor)
        {
            Origem = origem;
            Destino = destino;
            Valor = valor;
        }
    }
}
