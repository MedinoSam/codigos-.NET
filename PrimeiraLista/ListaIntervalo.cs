using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    internal class ListaIntervalo
    {
        public List<Intervalo> IntervalosList;

        public ListaIntervalo(List<Intervalo> intervalos)
        {
            IntervalosList = intervalos;
        }

        public ImmutableList<Intervalo> Intervalos
        {
            get
            {
                return IntervalosList.OrderBy(i => i.DataHoraInicial).ToImmutableList();
            }
        }


        public bool ContemIntersecao(Intervalo a)
        {
            foreach (Intervalo item in IntervalosList)
            {
                if (item.TemIntersecao(a))
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Intervalo a)
        {
            if (!ContemIntersecao(a))
                {
                IntervalosList.Add(a);
                }
        }
    }
}
