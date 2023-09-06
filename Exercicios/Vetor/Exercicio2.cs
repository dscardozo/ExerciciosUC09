using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Exercicio2
    {
        internal static void Executar()
        {
            int tamanhoDoVetor = 3;
            double[] notaP1 = new double[tamanhoDoVetor];
            double[] notaP2 = new double[tamanhoDoVetor];

            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                Console.WriteLine($"Informe a nota da P1 do {i + 1}º aluno : ");
                notaP1[i] = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.WriteLine($"Informe a nota da P2 do {i + 1}º aluno : ");
                notaP2[i] = double.Parse(Console.ReadLine().Replace('.', ','));
            }

            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                double media = (notaP1[i] + notaP2[i]) / 2;
                Console.Write($"Média do {i + 1}º aluno : {media:N2}");
                if (media >= 7.00)
                {
                    Console.WriteLine(" - Aprovado");
                }
                else if (media < 7.00 && media > 4.50)
                {
                    Console.WriteLine(" - Recuperação");
                }
                else
                {
                    Console.WriteLine(" - Reprovado");
                }
            }

        }
    }
}
