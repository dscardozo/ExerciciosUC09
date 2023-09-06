using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Ex
{
    internal static class LetrasDasPalavras
    {
        internal static void Executar()
        {
            Console.WriteLine("Informe a palavra a ser contatdas as letras: ");
            string palavras = Console.ReadLine().ToLower();

            //var palavraVetor = palavras.ToArray();
            char[] letras = new char[] { 'a', 'e', 'i', 'o', 'u', 'b', 'n' };

           // int[] contador = new int[palavras.Length];
            for (int i = 0; i < letras.Length; i++)

                //for (int i = 0; i < palavraVetor.Length; i++)
            {
            //    contador[i]++;
            //}


            //for (int i = 0; i < palavras.Length; i++)
            //{
                //Console.WriteLine($"A letra {palavras[i]} aparece {contador[i]} vezes.");
                Console.WriteLine($"A letra {letras[i]} aparece {palavras.Count(x => x == letras[i])} vezes.");
            }
        }
    }
}
