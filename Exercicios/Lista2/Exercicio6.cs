using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio6
    {
        internal static void Executar()
        {
            int bra, arg;
            Console.WriteLine("Informe a quantidade de gols do Brasil: ");
            bra = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de gols da Argentina: ");
            arg = Convert.ToInt32(Console.ReadLine());

            if (bra > arg)
            {
                Console.WriteLine($"Vitória do BRASIL");
            }else if (bra < arg)
            {
                Console.WriteLine($"Vitória da ARGENTINA");
            }
            else
            {
                Console.WriteLine("EMPATE");
            }
            Console.WriteLine($"Placar {bra} X {arg}");
        }
    }
}
