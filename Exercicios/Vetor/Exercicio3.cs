using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Exercicio3
    {
        internal static void Executar()
        {
            int tamanhoDoVetor = 3;
            string[] produtos = new string[tamanhoDoVetor];
            double[] precos = new double[tamanhoDoVetor];
            int[] quantidades = new int[tamanhoDoVetor];

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º produto : ");
                produtos[i] = Console.ReadLine();

                Console.Write($"Digite o preço do {i + 1}º produto : ");
                precos[i] = double.Parse(Console.ReadLine().Replace('.', ','));

                Console.Write($"Digite a quantidade vendida do {i + 1}º produto : ");
                quantidades[i] = int.Parse(Console.ReadLine());
            }

            double totalPagar = 0;
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("PRODUTOS\t|PREÇO\t|QUANTIDADE\t|TOTAL");
            for (int i = 0; i < produtos.Length; i++)
            {
                double totalProduto = precos[i] * quantidades[i]; 
                Console.WriteLine($"{produtos[i]}\t\t|R${precos[i]:N2}\t|{quantidades[i]}\t\t|R${totalProduto:N2}");

                totalPagar += totalProduto; 
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"TOTAL A PAGAR: R${totalPagar:N2}");
        }
    }
}
