using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio1
    {
        internal static void Executar()
        {
            int velocidade;

            Console.WriteLine("Informe a Velocidade do Veículo: ");
            velocidade = Convert.ToInt32(Console.ReadLine());

            if (velocidade > 60)
            {
                Console.WriteLine("MULTA!! Velocidade permitidade excedida");
            }
            else
            {
                Console.WriteLine("Sem multa, velocidade permitida");
            }
        }
    }
}
