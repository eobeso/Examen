using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string SalidaLista = string.Empty;
            List<List<decimal>> obj = new MoneyParts().build(Convert.ToDecimal(s));
            foreach (List<decimal> Grupos in obj)
            {
                SalidaLista = SalidaLista + "[";
                foreach (decimal Numero in Grupos)
                {
                    SalidaLista = SalidaLista + Numero + ",";
                }
                SalidaLista = SalidaLista.Remove(SalidaLista.Length - 1);
                SalidaLista = SalidaLista + "],";
            }
            Console.WriteLine(SalidaLista.Remove(SalidaLista.Length - 1));
            Console.ReadKey();
        }
    }
}
