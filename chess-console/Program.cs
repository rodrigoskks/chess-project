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
                        Console.Write("Informe a Posição de Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().converteParaPosicao();
                        partida.validarPosicaoDeOrigem(origem); 

                        bool[,] posicoesPossiveis = partida.tabuleiro.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.exibirTabuleiro(partida.tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Informe a Posição de Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().converteParaPosicao();

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
