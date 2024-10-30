using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public class Motor
    {
        public double Cilindrada { get; private set; }
        public Carro Car { get; private set; }

        public Motor(double cilindrada) 
        {
            Cilindrada = cilindrada;
        }
        public void InstalarEmCarro(Carro carro)
        {
            if (carro != null)
                throw new InvalidOperationException("O motor esta  em outro carro.");

            Car = carro;
        }

        public void RemoverDeCarro()
        {
            Car = null;
        }
    }
}
