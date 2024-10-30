using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public class Poligono
    {
        public List<Vertice> Vertices { get;  }

        public Poligono(List<Vertice> vertices) 
        { 
            if (vertices.Count < 3)
            {
                throw new ArgumentException("Numero de vertices eh no minimo 3");
            }
            Vertices = vertices;    
        }
        public int QuantidadeVertices
        {
            get
            {
                return Vertices.Count;
            }
        }

        public bool VerificarVerticesIguais(Vertice v, Vertice z)
        {
            return v.X == z.X && v.Y == z.Y;
        }

        public bool PertencePoligono(Vertice v) 
         {
            foreach (var item in Vertices)
            {
                if (VerificarVerticesIguais(item, v))
                     return true;
            }
            return false;
        }
        public  bool AddVertice(Vertice v)
        {
            if (!PertencePoligono(v))
            {
                Vertices.Add(v);
                return true;
            }
            return false;
        }
        public void RemoverVertice(Vertice v)
        {
            if (!PertencePoligono(v) || Vertices.Count - 1 < 3)
            {
                throw new ArgumentException("Vertice nao pertence ao poligono ou numero de vertices menor que 3 ");
            }
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (VerificarVerticesIguais(Vertices[i], v))
                {
                    Vertices.RemoveAt(i);
                }
            }
        }

        public double DistanciaVertices(Vertice v, Vertice z)
        {
            return Math.Sqrt(Math.Pow(v.X - z.X, 2) + Math.Pow(v.Y - z.Y, 2));
        }

        public double CalcularPerimetro()
        {
            double perimetro = 0;

            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertice verticeAtual = Vertices[i];
                Vertice proximoVertice = Vertices[(i + 1) % Vertices.Count];
                perimetro += DistanciaVertices(verticeAtual, proximoVertice);
            }
            return perimetro;
        }
        public override string ToString()
        {
            return "Polígono com vértices: " + string.Join(", ", Vertices);
        }

    }
}
