using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio2
    {
        internal static void Executar() 
        {
            double medida;
            Console.WriteLine("Informe o diametro da caneta: ");
            medida = double.Parse(Console.ReadLine());
            if (medida == 1)
            {
                Console.WriteLine("MEDIÇÃO IDEAL");
            }
            else
            {
                Console.WriteLine("MEDIÇÃO NÃO IDEAL");
            }
        }
    }
}
