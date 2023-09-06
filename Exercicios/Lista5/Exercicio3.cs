using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista5
{
    internal static class Exercicio3
    {
        internal static void Executar()
        {
            //const int MaxFuncionarios = 20;

            int totalFuncionarios = 0;
            int totalPrestadores = 0;
            int totalEstagiarios = 0;
            double totalFuncionariosPagamentos = 0;
            double totalPrestadoresPagamentos = 0;
            double totalEstagiariosPagamentos = 0;

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Informe o código do colaborador {0} (1=funcionário, 2=prestador de serviços, 3=estagiário ou 0 para sair):", i);
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0)
                {
                    break;
                }

                if (codigo < 1 || codigo > 3)
                {
                    Console.WriteLine("Código inválido, tente novamente.");
                    i--;
                    continue;
                }

                Console.WriteLine("Informe a quantidade de horas trabalhadas no mês:");
                int horasTrabalhadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor do salário por hora:");
                double salarioPorHora = double.Parse(Console.ReadLine());

                double pagamento = horasTrabalhadas * salarioPorHora;

                switch (codigo)
                {
                    case 1:
                        totalFuncionarios++;
                        totalFuncionariosPagamentos += pagamento;
                        break;
                    case 2:
                        totalPrestadores++;
                        totalPrestadoresPagamentos += pagamento;
                        break;
                    case 3:
                        totalEstagiarios++;
                        totalEstagiariosPagamentos += pagamento;
                        break;
                }
            }

            Console.WriteLine("Total de funcionários: {0}", totalFuncionarios);
            Console.WriteLine("Total de pagamentos para funcionários: {0}", totalFuncionariosPagamentos.ToString("C2"));
            Console.WriteLine("Total de prestadores de serviços: {0}", totalPrestadores);
            Console.WriteLine("Total de pagamentos para prestadores de serviços: {0}", totalPrestadoresPagamentos.ToString("C2"));
            Console.WriteLine("Total de estagiários: {0}", totalEstagiarios);
            Console.WriteLine("Total de pagamentos para prestadores de serviços: {0}", totalEstagiariosPagamentos.ToString("C2"));
            Console.ReadKey();
        }
    }
}
