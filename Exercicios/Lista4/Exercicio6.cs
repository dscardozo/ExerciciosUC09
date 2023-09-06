using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista4
{
    internal static class Exercicio6
    {
        internal static void Executar()
        {
            int baseTriangulo, alturaTriangulo;
            double areaTriangulo, maiorArea = 0, menorArea = double.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite a base do {0}º triângulo : ", i);
                baseTriangulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a altura do {0}º triângulo : ", i);
                alturaTriangulo = int.Parse(Console.ReadLine());

                areaTriangulo = (baseTriangulo * alturaTriangulo) / 2.0;

                if (areaTriangulo > maiorArea)
                {
                    maiorArea = areaTriangulo;
                }

                if (areaTriangulo < menorArea)
                {
                    menorArea = areaTriangulo;
                }
            }

            Console.WriteLine("A maior área calculada foi: {0}", maiorArea);
            Console.WriteLine("A menor área calculada foi: {0}", menorArea);
        }
    }
}
