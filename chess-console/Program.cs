using System;
using tabuleiro;
using xadrez;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.partidaTerminada)
                {
                    try
                    {
<<<<<<< HEAD

=======
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
                        Console.Clear();
                        Tela.exibirPartida(partida);

                        Console.WriteLine();
<<<<<<< HEAD
                        Console.Write("Informe a Posição de Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().converteParaPosicao();
                        partida.validarPosicaoDeOrigem(origem); 

                        bool[,] posicoesPossiveis = partida.tabuleiro.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.exibirTabuleiro(partida.tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Informe a Posição de Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().converteParaPosicao();
=======
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().converteParaPosicao();
                        partida.validarPosicaoOrigem(origem);

                        bool[,] possicoesPossiveis = partida.tabuleiro.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.exibirTabuleiro(partida.tabuleiro, possicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().converteParaPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
