using System.Collections.Generic;
using System.Linq;

namespace Problema2
{
    class CompleteRange
    {
        public List<int> build(List<int> ListaNumeros)
        {
            List<int> ListaRango = new List<int>();
            int Longitud = ListaNumeros.Max();
            ListaRango = Enumerable.Range(1, Longitud).ToList();
            return ListaRango;
        }
    }
}
