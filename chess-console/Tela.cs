using System;
using tabuleiro;

namespace chess_console
{
    class Tela
    {
        public static void exibirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int i = 0; i<tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        exibirPeca(tabuleiro.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void exibirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor auxiliar = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = auxiliar;
            }
        }
    }
}
