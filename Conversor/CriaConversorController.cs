using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public static class CriaConversorController
    {
        public static void CriaConversor(string origem, string destino, float valor)
        {
            var conversor = new Conversor(origem, destino, valor);
            var taxas = new Taxas();
            taxas.Import(conversor);
        }
    }
}
