using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Ex
{
    internal static class Foreach
    {
        internal static void Executar()
        {
            string[] nomes = new string[] { "Leandro", "Danilo", "Felipe", "Wesley" };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
