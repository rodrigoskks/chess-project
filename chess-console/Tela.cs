using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace chess_console
{
    class Tela
    {

        public static void exibirPartida(PartidaDeXadrez partida)
        {
            exibirTabuleiro(partida.tabuleiro);

            Console.WriteLine();
            exibirPecasCapturadas(partida);

            
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
        }

        public static void exibirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");
            Console.Write("Brancas: ");
            exibirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            exibirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.WriteLine();
        }

        public static void exibirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void exibirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    exibirPeca(tabuleiro.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void exibirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGreen;

            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }

                    exibirPeca(tabuleiro.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            try
            {
                string posicaoInformada = Console.ReadLine();

                char coluna = posicaoInformada[0];
                int linha = int.Parse(posicaoInformada[1] + "");

                return new PosicaoXadrez(coluna, linha);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static void exibirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
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
                Console.Write(" ");
            }
        }
    }
}
