using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio8
    {
        internal static void Executar()
        {
            double veiculo, radar, velPermitida;
            Console.WriteLine("Informe o Limite de velocidade: ");
            velPermitida = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a velocidade do veículo:");
            veiculo= Convert.ToDouble(Console.ReadLine());

            if(velPermitida <= 100)
            {
                radar = velPermitida + 7;
            }
            else
            {
                radar = velPermitida * 1.07;
            }

            if(veiculo > velPermitida)
            {
                Console.WriteLine($"MULTA!! A velocidade permitida é {velPermitida} KM/h com a tolerância de {radar} KM/h" +
                    $" e você estava a {veiculo}");
            }
            
        }
    }
}
