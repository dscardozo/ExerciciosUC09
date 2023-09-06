using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista1
{
    internal static class Exercicio5
    {
        internal static void Executar()
        {
            double km, milhas;
            try
            {
                Console.WriteLine("Informe a Velocidade em Km para converter em Milhas: ");
                km = Convert.ToDouble(Console.ReadLine());
                milhas = km / 1.609;
                Console.WriteLine($"{km} KM em Milhas: {Math.Round(milhas)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            
        }
    }
}
