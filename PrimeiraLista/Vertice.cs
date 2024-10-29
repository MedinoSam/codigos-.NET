using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public class Vertice
    {
        public double X {  get; private set; }
        public double Y { get; private set; }

        public Vertice(double x, double y) 
        {
            this.X = x;
            this.Y = y;
        }
        public double Distancia(Vertice b)
        {
            double x = this.X;
            double y = this.Y; 
            return Math.Sqrt(Math.Pow(b.X - x, 2) + Math.Pow(b.Y - y, 2));
        }
        
        public void Move()
        {
            double x, y;
            Console.WriteLine("Digite as coordenadas x e y que desejas mover o vertice");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            this.X = x;
            this.Y = y;
            Console.WriteLine($"Coordenadas alteradas para x = {x} e y = {y}", x, y);
        }
        public bool Igual(Vertice b)
        {
            if (this.X == b.X &&  this.Y == b.Y)
            {
                Console.WriteLine(" Os vertices sao iguais");
                return true;
            }
            else
                Console.WriteLine(" Os vertices sao diferentes");
                return false;
        }

    }
}
