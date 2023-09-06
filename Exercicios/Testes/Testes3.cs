using System;

namespace Algoritimos.Testes
{
    internal static class Testes3
    {
        static char[,] tabuleiro = new char[3, 3];

        internal static void Executar()
        {
            
            for (int lin = 0; lin < 3; lin++)
            {
                for (int col = 0; col < 3; col++)
                {
                    tabuleiro[lin, col] = ' ';
                }
            }

            bool acabou = false;
            char jogadorAtual = 'X';

            while (!acabou)
            {
                Console.Clear();
                Console.WriteLine("   1  2  3");
                Console.WriteLine("1 [{0}][{1}][{2}]", tabuleiro[0, 0], tabuleiro[0, 1], tabuleiro[0, 2]);
                Console.WriteLine("2 [{0}][{1}][{2}]", tabuleiro[1, 0], tabuleiro[1, 1], tabuleiro[1, 2]);
                Console.WriteLine("3 [{0}][{1}][{2}]", tabuleiro[2, 0], tabuleiro[2, 1], tabuleiro[2, 2]);

                Console.WriteLine($"Jogador {jogadorAtual}, informe a posição que deseja jogar (ex: 1,2):");
                string entrada = Console.ReadLine();

                int linha = int.Parse(entrada.Substring(0, 1)) - 1;
                int coluna = int.Parse(entrada.Substring(2, 1)) - 1;

                if (tabuleiro[linha, coluna] == ' ')
                {
                    tabuleiro[linha, coluna] = jogadorAtual;
                }
                else
                {
                    Console.WriteLine("A posição informada já foi jogada. Pressione qualquer tecla para jogar novamente.");
                    Console.ReadKey();
                    continue;
                }

                char vencedor = VerificarVencedor();
                if (vencedor == 'X' || vencedor == 'O')
                {
                    Console.Clear();
                    Console.WriteLine("Jogo da Velha");
                    Console.WriteLine("------------");
                    Console.WriteLine("Jogador {0} venceu!", vencedor);
                    acabou = true;
                }
                else if (Empate())
                {
                    Console.Clear();
                    Console.WriteLine("Jogo da Velha");
                    Console.WriteLine("------------");
                    Console.WriteLine("O jogo terminou empatado!");
                    acabou = true;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        static bool Empate()
        {
            for (int lin = 0; lin < 3; lin++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (tabuleiro[lin, col] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static char VerificarVencedor()
        {
            if (tabuleiro[0, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 2] == 'X' ||
                tabuleiro[0, 2] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 0] == 'X')
            {
                return 'X';
            }

            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == 'X' && tabuleiro[i, 1] == 'X' && tabuleiro[i, 2] == 'X' ||
                    tabuleiro[0, i] == 'X' && tabuleiro[1, i] == 'X' && tabuleiro[2, i] == 'X')
                {
                    return 'X';
                }
            }

            if (tabuleiro[0, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 2] == 'O' ||
                tabuleiro[0, 2] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 0] == 'O')
            {
                return 'O';
            }

            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == 'O' && tabuleiro[i, 1] == 'O' && tabuleiro[i, 2] == 'O' ||
                    tabuleiro[0, i] == 'O' && tabuleiro[1, i] == 'O' && tabuleiro[2, i] == 'O')
                {
                    return 'O';
                }
            }

            return ' ';
        }
    }
}