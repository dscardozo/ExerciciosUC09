using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista6
{
    internal static class Exercicio5
    {
        internal static void Executar()
        {

            int sexo, idade, soma_idade_homens = 0, soma_idade_mulheres = 0, qtd_homens = 0, qtd_mulheres = 0;

            for (int i = 1; i <= 12; i++)
            {
                Console.Write("Informe o código do sexo (1=Homens e 2=Mulheres) do funcionário {0}: ", i);
                sexo = int.Parse(Console.ReadLine());

                Console.Write("Informe a idade do funcionário {0}: ", i);
                idade = int.Parse(Console.ReadLine());

                while ((idade >= 0 && idade <= 99) && (sexo == 1 || sexo == 2))
                {
                    if (sexo == 1)
                    {
                        soma_idade_homens += idade;
                        qtd_homens++;
                    }
                    else
                    {
                        soma_idade_mulheres += idade;
                        qtd_mulheres++;
                    }
                    break;
                }
                if (idade < 0 || idade > 99 || (sexo != 1 && sexo != 2))
                {
                    Console.WriteLine("Encerrando o programa. Informações inválidas.");
                    break;
                }
            }
            if (qtd_homens > 0)
            {
                Console.WriteLine("Quantidade de funcionários homens: " + qtd_homens);
                Console.WriteLine("Média de idade dos homens: " + (double)soma_idade_homens / qtd_homens);
            }
            if (qtd_mulheres > 0)
            {
                Console.WriteLine("Quantidade de funcionárias mulheres: " + qtd_mulheres);
                Console.WriteLine("Média de idade das mulheres: " + (double)soma_idade_mulheres / qtd_mulheres);
            }
            Console.ReadLine();
        }
    }
}
