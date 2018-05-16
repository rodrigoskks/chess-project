using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace chess_console
{
    class Tela
    {
<<<<<<< HEAD
        public static void exibirPartida(PartidaDeXadrez partida)
        {
            exibirTabuleiro(partida.tabuleiro);
            Console.WriteLine();
            exibirPecasCapturadas(partida);
            Console.WriteLine();
=======

        public static void exibirPartida(PartidaDeXadrez partida)
        {
            exibirTabuleiro(partida.tabuleiro);

            Console.WriteLine();
            exibirPecasCapturadas(partida);

            
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
        }

        public static void exibirPecasCapturadas(PartidaDeXadrez partida)
        {
<<<<<<< HEAD
            Console.WriteLine("Peças Capturadas: ");
=======
            Console.WriteLine("Peças capturadas: ");
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
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
<<<<<<< HEAD
            foreach(Peca peca in conjunto)
            {
                Console.Write(peca + " ");
=======
            foreach(Peca x in conjunto)
            {
                Console.Write(x + " ");
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
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
<<<<<<< HEAD
                    exibirPeca(tabuleiro.peca(i, j));                    
=======
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
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
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
<<<<<<< HEAD
            }
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
=======
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

    }
}
