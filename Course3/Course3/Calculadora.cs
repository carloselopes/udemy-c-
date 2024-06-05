using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3
{
    internal class Calculadora
    {
        public static int Sum(params int[] numeros)
        {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            return sum;
        }
    }
}
