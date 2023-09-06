using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Desafio1
    {
        internal static void Executar()
        {
            bool jogarNovamente;
            do
            {
                List<string> letrasUtilizadas = new List<string>();

                Console.WriteLine("Informe a palavra secreta: ");
                string palavraSecreta = Console.ReadLine().ToUpper();

                Console.WriteLine("Informe uma dica: ");
                string dica = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Quantas chances você deseja? ");
                int chances = int.Parse(Console.ReadLine());
                Console.WriteLine($"A palavra secreta possui {palavraSecreta.Length} letras.");
                Console.WriteLine($"A dica é {dica}");

                string[] palavraExibida = new string[palavraSecreta.Length];
                string[] palavraCorreta = new string[palavraSecreta.Length];

                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    palavraExibida[i] = " _";
                    palavraCorreta[i] = palavraSecreta[i].ToString();
                }

                do
                {
                    Console.WriteLine($" --> Você tem {chances} chances <--");
                    Console.WriteLine("As letras já utilzadas foram : " + string.Join(" - ", letrasUtilizadas));

                    Console.WriteLine("Informe uma letra: ");
                    string letra = "";

                    while (letra.Length != 1)
                    {
                        letra = Console.ReadLine().ToUpper();

                        if (letra.Length != 1)

                            Console.WriteLine("Informe apenas uma letra! Tente novamente");

                        if (letrasUtilizadas.Contains(letra))
                        {
                            Console.WriteLine($"Você já utilizou a letra '{letra}'. Tente outra letra : ");
                            letra = "";
                            Console.WriteLine("As letras já utilizadas foram : " + string.Join(" - ", letrasUtilizadas));
                        }
                    }
                    letrasUtilizadas.Add(letra);

                    bool existe = false;

                    for (int j = 0; j < palavraSecreta.Length; j++)
                    {
                        if (letra == palavraCorreta[j])
                        {
                            palavraExibida[j] = letra;
                            existe = true;

                        }
                        Console.Write(palavraExibida[j]);
                    }
                    Console.WriteLine();
                    if (existe)
                    {
                        Console.WriteLine("Você acertou uma letra! Qual é a palavra secreta? ");
                        string tentativa = Console.ReadLine().ToUpper();

                        if (tentativa == palavraSecreta)
                        {
                            Console.WriteLine("Parabéns, você acertou a palavra secreta!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Você errou a palavra secreta! Tente a próxima letra.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"A letra {letra} não está na palavra secreta.");
                        chances--;
                    }
                } while (chances > 0);

                if (chances == 0)
                {
                    Console.WriteLine("Última chance!!! Qual é a palavra secreta? ");
                    string tentativa = Console.ReadLine().ToUpper();

                    if (tentativa == palavraSecreta)
                    
                        Console.WriteLine("Parabéns, você acertou a palavra secreta!");
                    
                    else

                        Console.WriteLine("Suas chances acabaram! A palavra secreta era " + palavraSecreta);
                }

                Console.WriteLine("Deseja jogar novamnete? Sim (S) ou qualquer tecla para sair");
                string resposta = Console.ReadLine().ToUpper();

                jogarNovamente = (resposta.ToUpper() == "S");

            } while (jogarNovamente);

            Console.WriteLine("Fim do jogo. Pressione uma tecla para sair.");

            Console.ReadKey();
        }
    }
}