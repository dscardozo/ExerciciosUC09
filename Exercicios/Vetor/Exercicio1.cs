using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Exercicio1
    {
        internal static void Executar()
        {
            CodigoSexo[] codigo = new CodigoSexo[5];
            int[] idade = new int[5];
            string[] nomeHomem = new string[5];
            string[] nomeMulher = new string[5];

            string nome;
            int qtdHomens = 0;
            int somaIdadesHomens = 0;
            int qtdMulheres = 0;
            int somaIdadesMulheres = 0;
            

            
            for (int i = 0; i < codigo.Length; i++)
            {
                Console.Write($"Digite o código do sexo (1=homem, 2=mulher) do {i + 1}º funcionário : ");
                int abc = Convert.ToInt32(Console.ReadLine());
                codigo[i] = (CodigoSexo)abc;
                Console.WriteLine($"Informe o nome do {i+1}º funcionário :");
                nome = Console.ReadLine();
                
                Console.Write($"Digite a idade do {i + 1}º funcionário : ");
                idade[i] = int.Parse(Console.ReadLine());

                if (codigo[i] == CodigoSexo.Homem)
                {
                    nomeHomem[i] = nome;
                    qtdHomens++;
                    somaIdadesHomens += idade[i];
                }
                else if (codigo[i] == CodigoSexo.Mulher)
                {
                    nomeMulher[i] = nome;
                    qtdMulheres++;
                    somaIdadesMulheres += idade[i];
                }
                else
                {
                    Console.WriteLine("Código do sexo inválido.");
                    i--;
                }
            }

            double mediaIdadeHomens = (double)somaIdadesHomens / qtdHomens;
            double mediaIdadeMulheres = (double)somaIdadesMulheres / qtdMulheres;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Quantidade de homens: {qtdHomens}");
            for (int i = 0; i < 5; i++)
            {
                if (nomeHomem[i] != null)
                    Console.WriteLine($"{nomeHomem[i]} tem {idade[i]} anos de idade");                    
            }
            Console.WriteLine($"Média de idade dos homens: {mediaIdadeHomens:N2}");

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine($"Quantidade de mulheres: {qtdMulheres}");
            for (int i = 0; i < 5; i++)
            {
                if (nomeMulher[i] != null)
                    Console.WriteLine($"{nomeMulher[i]} tem {idade[i]} anos de idade");
            }
            Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres:N2}");
        }
    }
    
}
