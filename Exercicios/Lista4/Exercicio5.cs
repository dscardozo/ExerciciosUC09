using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista4
{
    internal static class Exercicio5
    {
        internal static void Executar()
        {
            int num, qtdPar, qtdImpar;
            qtdPar = 0;
            qtdImpar = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informe 10 números Inteiros: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num % 2 == 0)
                {
                    qtdPar++;
                }
                else
                {
                    qtdImpar++;
                }
            }
            Console.WriteLine($"Quantidade de números Pares {qtdPar}");
            Console.WriteLine($"Quantidade de números Impares {qtdImpar}");
        }
    }
}
