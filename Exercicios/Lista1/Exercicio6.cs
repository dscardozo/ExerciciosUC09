using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista1
{
    internal static class Exercicio6
    {
        internal static void Executar()
        {
            double uc, numMax, num, qtdCargaHoraria;
            Console.WriteLine("Informe a UC : ");
            uc = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Carga Horária:");
            qtdCargaHoraria = double.Parse(Console.ReadLine());
            num = 3.5;
            numMax = (qtdCargaHoraria / num) * 0.25;

            Console.WriteLine($"{numMax}");
        }
    }
}
