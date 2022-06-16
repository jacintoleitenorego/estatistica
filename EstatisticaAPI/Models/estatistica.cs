using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstatisticaAPI.Models
{
    public class estatistica
    {
        public double Media(double[] valor)
        {
            double soma = 0;
            for(int i = 0; i < valor.Length; i++)
            {
                soma = soma + valores[i];
            }
            double resultado = soma / valor.Length;
            return resultado;
        }
    }
}