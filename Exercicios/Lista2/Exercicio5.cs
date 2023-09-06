using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio5
    {
        internal static void Executar()
        {
            double lado1, lado2, lado3;
            Console.WriteLine("Informe o lado 1 do Triangulo: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado 2 do Triangulo: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado 3 do Triangulo: ");
            lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
            {
                Console.WriteLine("Triangilo EQUILATERO");
            }
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {
                Console.WriteLine("Triangilo ESCALENO");
            }
            else
            {
                Console.WriteLine("Triangilo ISÓSCELES");
            }
        }
    }
}
