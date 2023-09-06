using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista1
{
    internal static class Exercicio1
    {
        internal static void Executar()
        {
            string nome;
            int idade, anoNascimento;

            try
            {
                Console.WriteLine("Informe o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe seu ano de nascimento: ");
                anoNascimento = Convert.ToInt32(Console.ReadLine());
                idade = DateTime.Now.Year - anoNascimento;

                Console.WriteLine($"{nome} você tem {idade} anos");
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
