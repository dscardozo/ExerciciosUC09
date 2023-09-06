using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista5
{
    internal static class Exercicio2
    {
        internal static void Executar()
        {
            Console.WriteLine("Digite o valor de n:");
            int n = Convert.ToInt32(Console.ReadLine()); //obtém valor de n

            double somatorio = 0; //variável para armazenar o resultado do somatório

            for (int i = 1; i <= n; i++)
            {
                somatorio += 1.0 / i; //faz a soma dos valores das frações correspondentes
            }

            Console.WriteLine($"O resultado do somatório de 1/1 até 1/{n} é: {somatorio}");
            Console.ReadKey();
        }
    }
}
