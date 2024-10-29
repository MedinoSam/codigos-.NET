using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public class Triangulo
    {
       

        public Vertice A { get; private set; }
        public Vertice B { get; private set; }
        public Vertice C { get; private set; }

        public Triangulo(Vertice a, Vertice b, Vertice c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimetro 
        {
            get
            {
                double distancia_AB = A.Distancia(B);
                double distancia_BC = B.Distancia(C);
                double distancia_AC = A.Distancia(C);
                return distancia_AB + distancia_BC + distancia_AC;
            }

        }

        public enum TipoTriangulo
        {
            Equilatero,
            Isoceles,
            Escaleno
        }


        public  TipoTriangulo Tipo
        {
            get
            {
                double distancia_AB = A.Distancia(B);
                double distancia_BC = B.Distancia(C);
                double distancia_AC = A.Distancia(C);
                if (distancia_AB == distancia_BC &&  distancia_BC == distancia_AC)
                {
                    return TipoTriangulo.Equilatero;
                }
                else if (distancia_AB == distancia_BC || distancia_BC == distancia_AC || distancia_AC == distancia_AB)
                {
                    return TipoTriangulo.Isoceles;
                }
                else
                {
                    return TipoTriangulo.Escaleno;
                }
            }
        }

        public double Area
        {
            get
            {
                double distancia_AB = A.Distancia(B);
                double distancia_BC = B.Distancia(C);
                double distancia_AC = A.Distancia(C);
                double s = (distancia_AB + distancia_AC + distancia_BC) / 2;
                return Math.Sqrt(s * (s - distancia_AB) * (s - distancia_BC) * (s - distancia_AC));
            }
        }
        public static bool EhTriangulo(Vertice a, Vertice b, Vertice c)
        {
            double distancia_AB = a.Distancia(b);
            double distancia_BC = b.Distancia(c);
            double distancia_AC = a.Distancia(c);

            return ((distancia_AB + distancia_BC > distancia_AC) && (distancia_AB + distancia_AC > distancia_BC) && (distancia_BC + distancia_AC > distancia_AB));
        }

        public bool EhIgual(Triangulo b)
        {
            return (this.A.Igual(b.A)) && (this.B.Igual(b.B)) && (this.C.Igual(b.C));
        }
    }
}
