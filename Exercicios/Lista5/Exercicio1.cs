using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista5
{
    internal static class Exercicio1
    {
        internal static void Executar()
        {
            int totalHomem = 0, totalMulher = 0, idade=0, totalIdadeHomem=0, totalIdadeMulher=0;
            double mediaHomem = 0, mediaMulher = 0;
            

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Informe o sexo do {0}º Funcionário  (1) Homem ou (2) Mulher ou (0) para sair):", i);
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0)
                {
                    break;
                }

                if (codigo < 1 || codigo > 2)
                {
                    Console.WriteLine("Código inválido, tente novamente.");
                    i--;
                    continue;
                }

                if (codigo == 1)
                {
                    Console.WriteLine("Informe a Idade do {0}º funcionário:", i);
                    totalHomem = totalHomem + 1;
                    idade = Convert.ToInt32(Console.ReadLine());
                    totalIdadeHomem = totalIdadeHomem + idade;
                }
                else
                {
                    Console.WriteLine("Informe a Idade do {0}º funcionário:", i);
                    totalMulher = totalMulher + 1;
                    idade = Convert.ToInt32(Console.ReadLine());
                    totalIdadeMulher = totalIdadeMulher + idade;
                }

            }
            mediaHomem = totalIdadeHomem / totalHomem;
            mediaMulher = totalIdadeMulher / totalMulher;
            Console.WriteLine($"{totalHomem} Homens com {mediaHomem} anos de Média de Idade");
            Console.WriteLine($"{totalMulher} Mulheres com {mediaMulher} anos de Média de Idade");
        }
    }
}
