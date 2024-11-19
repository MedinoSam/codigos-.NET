using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Conversor
{
    public class CalcularConversao
    {
        public void calculo(API_Obj dado, Conversor conversor)
        {
            float valor = conversor.Valor;
            string destino = conversor.Destino.ToUpper();
            float taxaCorrecao;
            float valorConvertido;
            foreach (var obj in dado.ConversionRates)
            {
                if (obj.Key == destino)
                {
                    taxaCorrecao = obj.Value;
                    valorConvertido = conversor.Valor * taxaCorrecao;
                    Console.WriteLine(valorConvertido);
                    break;
                }
            }
            

        }
    }
}
