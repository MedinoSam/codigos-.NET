using EllipticCurve.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{

    public class ArmazenaDadosView
    {
        public void ArmazenaDados()
        {
            while (true)
            {
                Console.WriteLine("Moeda origem: ");
                string origem = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(origem)) break; 
        
                Console.WriteLine("Moeda destino: ");
                string destino = Console.ReadLine();
                Console.WriteLine("Valor: ");
                float valor = float.Parse(Console.ReadLine());
                ValidarDados validador = new ValidarDados();
                validador.Validacao(origem, destino, valor);
            }



        }
    }
}
