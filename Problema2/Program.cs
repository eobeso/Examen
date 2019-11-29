using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var ListaNumeros = s.Split(',').Select(Int32.Parse).ToList();
            List<int> Lista = new CompleteRange().build(ListaNumeros);
            string SalidaLista= string.Empty;
            foreach (int Numeros in Lista)
            {
                SalidaLista = SalidaLista + Numeros + ",";
            }
            Console.WriteLine(SalidaLista.Remove(SalidaLista.Length - 1));
            Console.ReadKey();
        }
    }
}
