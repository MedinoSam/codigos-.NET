using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public static class ApresentaErrosView
    {
        public static void exibirErros(List<int> erros)
        {
            foreach (int ele in erros)
            {
                if (ele == 1)
                {
                    Console.WriteLine("Erro! as moedas precisam ter 3 caracteres ");
                }
                else if (ele == 2)
                {
                    Console.WriteLine("Erro! as moedas nao podem ser iguais");
                }
                else if (ele == 3) {
                    Console.WriteLine("Erro! o valor tem que ser positivo");
                }
            }

        }
    }
}
