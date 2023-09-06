using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritimos.Lista4
{
    internal static class Exercicio3
    {
        internal static void Executar()
        {
            int num, maior, menor;

            Console.WriteLine("Informe 10 numeros inteiros: ");
            num = Convert.ToInt32(Console.ReadLine());

            menor = num;
            maior = num;

            for (int i = 0; i < 9; i++) 
            {
                Console.WriteLine("Informe mais um número inteiro: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }
                else if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine($"O maior número é {maior} e o menor é {menor}");
        }
    }
}
