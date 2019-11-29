using System;
using System.Collections.Generic;

namespace Problema3
{
    class MoneyParts
    {
        public List<List<decimal>> build(decimal GrupoNumero)
        {
            List<List<decimal>> Lista = new List<List<decimal>>();
            decimal[] GrupoDecimal = new decimal[] { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };          
            foreach (var Numero in GrupoDecimal)
            {
                var ListaDecimal = new List<decimal>();
                if (GrupoNumero >= Numero)
                {
                    if (GrupoNumero % Numero == 0)
                    {
                        var obj = GrupoNumero / Numero;
                        for (int i = 0; i < obj; i++)
                        {
                            ListaDecimal.Add(Numero);
                        }
                    }
                    if (ListaDecimal.Count > 0)
                    {
                        Lista.Add(ListaDecimal);
                    }                    
                }
            }
            return Lista;
        }
    }
}
