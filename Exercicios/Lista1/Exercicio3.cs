using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista1
{
    internal static class Exercicio3
    {
        internal static void Executar()
        {
            double valor, dolar, vDolar;
            try
            {
                Console.WriteLine("Informe o valor em Real para converter para Dolar: ");
                valor = double.Parse(Console.ReadLine());
                dolar = 4.94;
                vDolar = valor / dolar;
                if (valor < 0) 
                {
                    Console.WriteLine("Informe um valor positivo!!!!");
                }

                Console.WriteLine($"Valor convertido {valor.ToString("C")} " +
                    $"em Dolar é {vDolar.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"))}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            


        }
    }
}
