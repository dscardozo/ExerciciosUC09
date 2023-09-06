using Algoritimos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista1
{
    internal static class Exercicio2
    {
        internal static void Executar()
        {
            int volume;

            try
            {
                CaixaAgua caixaAgua = new CaixaAgua();

                Console.WriteLine("Este Programa irá calcular o Volume de uma caixa D`água");
                Console.WriteLine("Informe a altura: ");
                caixaAgua.Altura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a largura: ");
                caixaAgua.Largura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a profundidade: ");
                caixaAgua.Profundidade = Convert.ToInt32(Console.ReadLine());
                volume = caixaAgua.CalcularVolume();

                Console.WriteLine($"O volume da caixa é:{volume}.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
