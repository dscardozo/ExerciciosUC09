using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista6
{
    internal static class Exercicio2
    {
        internal static void Executar() {

            double num=0, soma=0, media=0, qtd=0;
            Console.WriteLine("Informe números positivos :");
            num = Convert.ToDouble(Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine("Informe números : ");
                num = Convert.ToDouble(Console.ReadLine());
                qtd = qtd + 1;
                soma = soma + num;
                media = soma / qtd;

                if (num < 0)
                {
                    Console.WriteLine("Encerrando.....");
                    break;
                }                
            }
            Console.WriteLine($" - Soma :{soma}");
            Console.WriteLine($" - Média :{media}");
            Console.WriteLine($" - Quantidade : {qtd}");
        }
    }
}
