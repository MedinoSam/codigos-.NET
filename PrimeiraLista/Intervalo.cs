using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    internal class Intervalo
    {
        public DateTime DataHoraInicial { get; }
        public DateTime DataHoraFinal { get; }

        public Intervalo(DateTime dataHoraInicial, DateTime dataHoraFinal)
        {
            if (dataHoraFinal < dataHoraInicial)
            {
                throw new ArgumentException(" DataHora inicial menor que final");
            }
            DataHoraInicial = dataHoraInicial;
            DataHoraFinal = dataHoraFinal;
        }

        public bool TemIntersecao(Intervalo a)
        {
            return DataHoraInicial < a.DataHoraFinal && DataHoraFinal > a.DataHoraInicial;  
        }

        public bool EhIgual(Intervalo a)
        {
            return DataHoraInicial == a.DataHoraInicial && DataHoraFinal == a.DataHoraFinal;
        } 
        public TimeSpan Duracao()
        {
            return DataHoraFinal - DataHoraInicial;
        }

        public override string ToString()
        {
            return $"Intervalo de {DataHoraInicial} até {DataHoraFinal}, duração: {Duracao()}";
        }
    }
}
