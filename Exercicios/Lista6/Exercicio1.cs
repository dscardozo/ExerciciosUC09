using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Algoritimos.Lista6
{
    internal static class Exercicio1
    {
        internal static void Executar()
        {
            Console.WriteLine("Inserir notas:");

            double nota = 0;
            int contador = 0;
            double somaNotas = 0;
            bool maisNotas = true;

            while (maisNotas)
            {
                Console.Write("Insira a nota (de 0 a 10): ");
                nota = double.Parse(Console.ReadLine());

                somaNotas += nota;
                contador++;

                Console.Write("Deseja inserir mais notas (S/N)? ");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() != "S")
                {
                    maisNotas = false;
                }
            }

            double media = somaNotas / contador;
            Console.WriteLine("Média das notas: {0:N2}", media);
        }
    }
}

       