using System;
using tabuleiro;
using xadrez;

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

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string posicaoInformada = Console.ReadLine();

            char coluna = posicaoInformada[0];
            int linha = int.Parse(posicaoInformada[1] + "");

            return new PosicaoXadrez(coluna, linha);

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
