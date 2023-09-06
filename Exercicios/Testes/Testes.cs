using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algoritimos.Testes
{
    internal static class Testes
    {
        internal static void Executar()
        {
            Console.Write("Informe um cpf para validação: ");
            var cpf = Console.ReadLine();

            Regex regex = new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)", RegexOptions.IgnorePatternWhitespace);
            if (regex.IsMatch(cpf))
            {
                Console.WriteLine("CPF válido.");
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }

        }
    }
}
