using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class ValidarDados
    {
        
        public void Validacao(string origem, string destino, float valor)
        {
            List<int> erros = new List<int>();
            if (origem.Length != 3 || destino.Length != 3)
            {
                erros.Add(1);
            }
            if (origem == destino)
            {
                erros.Add(2);
            }
            if (valor < 0)
            {
                erros.Add(3);
            }
            if (erros.Count == 0)
            {
                CriaConversorController.CriaConversor(origem, destino, valor);
                
            }
            else
            {
                ApresentaErrosView.exibirErros(erros);
            }


        }
    }
}
