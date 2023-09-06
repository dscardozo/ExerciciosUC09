using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio4
    {
        internal static void Executar()
        {
            double vlrCompra, totalPagar, desconto;

            Console.WriteLine("Informe o valor da compra: ");
            vlrCompra = Double.Parse(Console.ReadLine());

            if (vlrCompra >= 100.00)
            {
                desconto = vlrCompra * 0.10;
                totalPagar = vlrCompra - desconto;
                Console.WriteLine($"Desconto de 10% , Valor Total a Pagar R$ {totalPagar}");
            }
            else
            {
                Console.WriteLine($"Valor a Pagar R$ {vlrCompra}");
            }
        }
    }
}
