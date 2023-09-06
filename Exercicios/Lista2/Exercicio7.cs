using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio7
    {
        internal static void Executar()
        {
            double num;

            Console.WriteLine("Informe um número: ");
            num= Convert.ToDouble(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"O número {num} é POSITIVO.");
            }else if (num < 0)
            {
                Console.WriteLine($"O número {num} é NEGATIVO.");
            }
            else
            {
                Console.WriteLine($"O número {num} é NEUTRO.");
            }
        }
    }
}
