using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Ex
{
    internal class MaiorDeIdade
    {
        internal static void Executar()
        {
            Console.WriteLine("Informe a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            string msg = idade >= 18 ? "Você é maior de idade." : "Você é menor de idade.";

            Console.WriteLine(msg);
        }
    }
}
