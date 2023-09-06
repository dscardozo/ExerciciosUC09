using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista1
{
    internal static class Exercicio4
    {
        internal static void Executar()
        {
            double bas, alt, area;
            try
            {
                Console.WriteLine("Informe a Base do Triangulo: ");
                bas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a Altura do Triangulo: ");
                alt = Convert.ToDouble(Console.ReadLine());

                area = bas * alt / 2;

                Console.WriteLine($"A Área do Triângulo é: {area}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
