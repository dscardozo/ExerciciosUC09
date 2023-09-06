using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Lista2
{
    internal static class Exercicio3
    {
        internal static void Executar()
        {
            double minutos;

            Console.WriteLine("Informe o tempo do vídeo a ser gravado: ");
            minutos = Convert.ToDouble(Console.ReadLine());

            if (minutos <= 120 && minutos > 0)
            {
                Console.WriteLine("Gravando.......");
            }
            else if (minutos <= 0)
            {
                Console.WriteLine("NÃO GRAVAR, informe um tempo valido.");
            }
            else
            {
                Console.WriteLine("NÃO GRAVAR, tempo máximo de gravação 120 minutos");
            }
        }
    }
}
