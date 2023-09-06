using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista3
{
    internal static class Exercicio5
    {
        internal static void Executar()
        {
            double kgPescado, excedente, multa;
            Console.WriteLine("Informe o Peso: ");
            kgPescado = Convert.ToDouble(Console.ReadLine());
            if (kgPescado > 50)
            {
                excedente = kgPescado - 50;
                multa = excedente * 4;
                Console.WriteLine($"O excedente foi de {excedente.ToString("F")} KGs e a Multa foi de {multa.ToString("C")}");
            }
            else
            {
                Console.WriteLine($"Sem Multa!!");
            }
        }
    }
}
