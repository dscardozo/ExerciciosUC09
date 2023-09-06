using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista3
{
    internal static class Exercicio3
    {
        internal static void Executar()
        {
            double desconto, compra, vlrPagar, porcentagemDeDesconto = 0;
            bool existeDesconto = false;
            string descontoStr = "";

            Console.WriteLine("Informe o valor da compra: ");
            compra = Convert.ToDouble(Console.ReadLine());

            if (compra > 1000)
            {
                existeDesconto = true;
                porcentagemDeDesconto = 0.20;
                descontoStr = "20%";
            }
            else
                if (compra > 500)
            {
                existeDesconto = true;
                porcentagemDeDesconto = 0.10;
                descontoStr = "10%";
            }
            else
                if (compra > 100)
            {
                existeDesconto = true;
                porcentagemDeDesconto = 0.05;
                descontoStr = "5%";                
            }

            if (existeDesconto)
            {
                desconto = Desconto(compra, porcentagemDeDesconto);
                vlrPagar = Calcular(compra, desconto);
                Console.WriteLine($"Desconto de {descontoStr} {desconto.ToString("C")}. Valor total a pagar é {vlrPagar.ToString("C")}");
            }
            else
            {
                Console.WriteLine($"Valor sem desconto. Valor total a pagar é R$ {compra.ToString("C")} ");
            }
        }

        internal static double Calcular(double valor, double desconto)
        {
            double valorPagar = valor - desconto;

            return valorPagar;
        }

        internal static double Desconto(double valor, double porcentagem)
        {
            double desconto = valor * porcentagem;

            return desconto;
        }

    }
}
