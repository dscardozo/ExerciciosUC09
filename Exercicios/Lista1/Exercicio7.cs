using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista1
{
    internal static class Exercicio7
    {
        internal static void Executar()
        {
            double prova1, prova2, trabalho, p1, p2, pT, notaFinal;

            Console.WriteLine("Informe nota da 1ª Prova: ");
            prova1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe nota da 2ª Prova: ");
            prova2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe nota do Trabalho: ");
            trabalho = Convert.ToDouble(Console.ReadLine());

            p1 = prova1 * 0.35;
            p2 = prova2 * 0.45;
            pT = trabalho * 0.20;

            notaFinal = p1 + p2 + pT;

            Console.WriteLine($"Sua média é: {notaFinal}");
        }
    }
}
