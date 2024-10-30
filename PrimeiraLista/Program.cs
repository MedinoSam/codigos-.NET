using PrimeiraLista;
using System;
using System.Diagnostics.CodeAnalysis;

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

            //trecho referente ao triangulo
            /*Vertice vertice1 = new Vertice(4, 5);
            Vertice vertice2 = new Vertice(3, 6);
            Vertice vertice3 = new Vertice(9, 5);

            Triangulo triangulo1 = new Triangulo(vertice1, vertice2, vertice3);

            Triangulo triangulo2 = new Triangulo(vertice3, vertice1, vertice2);*/


            //trecho referente ao poligono
            Vertice v1 = new Vertice(4, 5);
            Vertice v2 = new Vertice(3, 6);
            Vertice v3 = new Vertice(9, 5);
            Vertice v4 = new Vertice(1, 3);
            Poligono poligono = new Poligono(new List<Vertice> {v1, v2, v3 });
            Console.WriteLine(poligono);
            poligono.AddVertice(v4);
            Console.WriteLine(poligono);
            poligono.RemoverVertice(v1);
            Console.WriteLine(poligono);
            double perimetro = poligono.CalcularPerimetro();
            int qtdVertices = poligono.QuantidadeVertices;
            Console.WriteLine("perimetro do poligono: " + perimetro);
            Console.WriteLine("quantidade de vertices: " + qtdVertices);
        }
    }
}


