using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista6
{
    internal static class Exercicio3
    {
        internal static void Executar() 
        {
            double voucher = 150.00, soma = 0, vlrPagar = 0, vlr = 0, saldo = 0;
            
            while (vlr < voucher)
            {                
                if (soma <= voucher)
                {
                    Console.WriteLine("Informe o valor dos produtos:");
                    vlr = Convert.ToDouble(Console.ReadLine());
                    soma = soma + vlr;
                    saldo = voucher - soma;
                    Console.WriteLine($"Saldo do Voucher : {saldo.ToString("C")}");
                }
                else
                if (soma > voucher)                
                {                    
                    break;
                }
                vlrPagar = soma - voucher;                
            }
            Console.WriteLine($"Valor a Pagar R$ {vlrPagar.ToString("C")}");
        }
    }
}
