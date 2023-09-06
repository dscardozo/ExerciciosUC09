using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista3
{
    internal static class Exercicio4
    {
        internal static void Executar()
        {
            int idade;
            string msg;

            Console.WriteLine("Informe a idade: ");
            idade=Convert.ToInt32(Console.ReadLine());

            if (idade >= 5 && idade <=10)
            {
                msg = "Categoria INFANTIL";
                Console.WriteLine(msg);
            }
            else if (idade > 10 && idade <= 17)
            {
                msg = "Categoria JUVENIL";
                Console.WriteLine(msg);
            }
            else if (idade > 17)
            {
                msg = "Categoria ADULTO";
                Console.WriteLine(msg);
            }
        }
    }
}
