using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista4
{
    internal static class Exercicio1
    {
        internal static void Executar()
        {
            int num, soma;
            double media;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um número");
                num = Convert.ToInt32(Console.ReadLine());
                soma += num;
            }

            media = soma / 10;
            Console.WriteLine($"A média é :{media}");
        }
    }
}
