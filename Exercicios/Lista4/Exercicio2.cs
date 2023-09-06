using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista4
{
    internal static class Exercicio2
    {
        internal static void Executar()
        {
            int num, maior;
            maior = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe 10 números Inteiros: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > maior)
                {
                    maior = num;
                }
            }
            Console.WriteLine($"O maior número é {maior}");
        }
    }
}
