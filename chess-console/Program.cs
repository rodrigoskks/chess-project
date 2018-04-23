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
                        Console.Clear();
                        Tela.exibirPartida(partida);

                        Console.WriteLine();
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
