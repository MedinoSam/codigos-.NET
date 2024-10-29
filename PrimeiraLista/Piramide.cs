using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public class Piramide
    {
        public int N { get; set; }

        public Piramide(int n)
        {
            this.N = n;
        }

        public void Desenha()
        {
            int n = this.N;
            if (n < 1)
            {
                throw new NotFiniteNumberException();
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int j = i-1; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

}
