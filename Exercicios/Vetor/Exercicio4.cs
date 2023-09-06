using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Exercicio4
    {
        internal static void Executar()
        {
            int[] numeros = new int[50];
            int quantidadeNumeros = 0;

            do
            {
                Console.Write($"{quantidadeNumeros}) Digite um número entre 1 e 99 (0 para encerrar): ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0) 
                {
                    break;
                }
                else if (numero < 1 || numero > 99)
                {
                    continue;
                }

                numeros[quantidadeNumeros] = numero;
                quantidadeNumeros++;
            } while (quantidadeNumeros < 50);

            if (quantidadeNumeros == 0)
            {
                Console.WriteLine("Nenhum número foi informado.");
                return;
            }
            
            int maiorNumero = numeros[0];
            int menorNumero = numeros[0];
            int somaNumeros = 0;
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }

                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }

                somaNumeros += numeros[i];
            }

            double media = (double)somaNumeros / quantidadeNumeros;

            Console.WriteLine($"Maior número informado foi: {maiorNumero}");
            Console.WriteLine($"Menor número informado foi: {menorNumero}");
            Console.WriteLine($"Média dos números informados: {media:N2}");
        }
    }


}
