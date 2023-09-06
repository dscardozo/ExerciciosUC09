using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Exercicio7
    {
        internal static void Executar()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

                palavra = palavra.ToLower();

            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;

            for (int j = 0; j < palavra.Length; j++)
            {
                if (palavra[j] == 'a' || palavra[j] == 'ã' || palavra[j] == 'à' || palavra[j] == 'á')
                {
                    a++;
                }
                else if (palavra[j] == 'e' || palavra[j] == 'é')
                {
                    e++;
                }
                else if (palavra[j] == 'i' || palavra[j] == 'í')
                {
                    i++;
                }
                else if (palavra[j] == 'o' || palavra[j] == 'õ' || palavra[j] == 'ó')
                {
                    o++;
                }
                else if (palavra[j] == 'u' || palavra[j] == 'ú')
                {
                    u++;
                }
            }

            Console.WriteLine($"A letra 'a' se repete {a} vezes");
            Console.WriteLine($"A letra 'e' se repete {e} vezes");
            Console.WriteLine($"A letra 'i' se repete {i} vezes");
            Console.WriteLine($"A letra 'o' se repete {o} vezes");
            Console.WriteLine($"A letra 'u' se repete {u} vezes");
        }
    }
}
