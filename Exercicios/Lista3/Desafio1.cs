using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista3
{
    internal static class Desafio1
    {
        internal static void Executar()
        {
            double m3, vlrFixo, vlrAcumulado;
            int codigo;
            string fixo, acumulado;

            Console.WriteLine("Informe (1) para Valor Fixo ou (2) para Valor Acumulado: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o consumo em M³: ");
            m3 = Convert.ToDouble(Console.ReadLine());
            vlrFixo = 0;
            vlrAcumulado = 0;
            fixo = "Taxa Fixa.";
            acumulado = "Taxa Acumulada.";


            if (codigo == 1)
            {
                if (m3 > 0 && m3 <= 5)
                {
                    vlrFixo = m3 * 5;
                }
                else if (m3 > 5 && m3 <= 10)
                {
                    vlrFixo = m3 * 10;
                }
                else if (m3 > 10)
                {
                    vlrFixo = m3 * 15;
                }
                Console.WriteLine($"{fixo} O valor a pagar é R$ {vlrFixo}");
            }
            if (codigo == 2)
            {
                if (m3 > 0 && m3 <= 5)
                {
                    vlrAcumulado = m3 * 5;
                }
                else if (m3 > 5 && m3 <= 10)
                {
                    vlrAcumulado = (5 * 5) + ((m3 - 5) * 10);
                }
                else if (m3 > 10)
                {
                    vlrAcumulado = (5 * 5) + (5 * 10) + ((m3 - 10) * 15);
                }
                Console.WriteLine($"{acumulado} O valor a pagar é R$ {vlrAcumulado}");
            }
        }
    }
}
