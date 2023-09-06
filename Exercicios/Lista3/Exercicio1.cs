using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista3
{
    internal static class Exercicio1
    {
        internal static void Executar()
        {
            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Informe a  1ª Nota: ");
            nota1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a  2ª Nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a  3ª Nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a  4ª Nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            
            media = (nota1+nota2+nota3+nota4) / 4;

            if (media >= 5)
            {
                Console.WriteLine($"APROVADO sua média foi de {media}");
            }
            else 
            {
                Console.WriteLine($"REPROVADO sua média foi de {media}");
            }
        }
    }
}
