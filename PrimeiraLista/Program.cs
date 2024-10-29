using PrimeiraLista;
using System;

namespace PrimeiraLista
{
    class Program
    {
        static void Main(string[] args)
        {

            /* trecho referente a piramide
              Piramide piramide = new Piramide(4);
            piramide.Desenha();
            */

            /* trecho referente ao vertice
            Vertice vertice1 = new Vertice(4, 5);
            Vertice vertice2 = new Vertice(3, 6);

            Console.WriteLine("Distancia entre vertice 1 e vertice 2 eh: " + vertice1.Distancia(vertice2));
            vertice1.Move();
            vertice1.Igual(vertice2);
            */

            Vertice vertice1 = new Vertice(4, 5);
            Vertice vertice2 = new Vertice(3, 6);
            Vertice vertice3 = new Vertice(9, 5);

            Triangulo triangulo1 = new Triangulo(vertice1, vertice2, vertice3);

            Triangulo triangulo2 = new Triangulo(vertice3, vertice1, vertice2);
        }
    }
}


