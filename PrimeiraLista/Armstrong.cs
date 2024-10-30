using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public static class Armstrong
    {
        static int Potencia(int x, long y)
        {
            if (y == 0)
                return 1;
            if (y % 2 == 0)
                return Potencia(x, y / 2) *
                       Potencia(x, y / 2);
            return x * Potencia(x, y / 2) *
                       Potencia(x, y / 2);
        }
        static int Ordem(int x)
        {
            int n = 0;
            while (x != 0)
            {
                n++;
                x = x / 10;
            }
            return n;
        }
        public static bool isArmstrong(this int x)
        {
            int ordem = Ordem(x);
            int temp = x, soma = 0;
            while (temp != 0)
            {
                int resto = temp % 10;
                soma = soma + Potencia(resto, ordem);
                temp = temp / 10;
            }
            return (soma == x);
        }

        public static void printaArmastrong()
        {
            for (int i = 0; i < 10000; i++)
            {
                if (i.isArmstrong())
                    Console.WriteLine(i);
            }
        }
    }
}
