using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista6
{
    internal static class Exercicio4
    {
        internal static void Executar()
        {
            int voto = 0, totalVotos = 0, votos100 = 0, votos200 = 0, votosNulos = 0;

            Console.WriteLine("Bem-vindo às eleições! Escolha o seu partido (100 ou 200)" +
                " ou digite 1 para encerrar a votação:");

            while (voto != 1)
            {
                Console.Write("Digite o número do partido ou 1 para encerrar: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 100)
                {
                    votos100++;
                    totalVotos++;
                    Console.WriteLine("Voto confirmado 100!");
                }
                else if (voto == 200)
                {
                    votos200++;
                    totalVotos++;
                    Console.WriteLine("Voto confirmado 200!");
                }
                else if (voto != 1)
                {
                    votosNulos++;
                    totalVotos++;
                    Console.WriteLine("Voto nulo!");
                }
            }

            double porcentagemNulos = (double)votosNulos / totalVotos * 100;
            double porcentagem100 = (double)votos100 / totalVotos * 100;
            double porcentagem200 = (double)votos200 / totalVotos * 100;

            Console.WriteLine("Resultado das eleições:");
            Console.WriteLine("Partido 100 teve {0} votos e {1:N2}% dos votos", votos100, porcentagem100);
            Console.WriteLine("Partido 200 teve {0} votos e {1:N2}% dos votos", votos200, porcentagem200);
            Console.WriteLine("Votos nulos totais: {0} com {1:N2}% dos votos", votosNulos, porcentagemNulos);
        }
    }
}
