using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista3
{
    internal static class Exercicio2
    {
        internal static void Executar()
        {
            double num1, num2, diferenca;
            Console.WriteLine("Informe um número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe outro número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                diferenca = num1 - num2;
            }
            else
            {
                diferenca = num2 - num1;
            }
            Console.WriteLine($"A diferença entre {num1} e {num2} é {diferenca}");
        }
    }
}
