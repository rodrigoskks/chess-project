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
                //PosicaoXadrez posicao = new PosicaoXadrez('c', );
                //Console.WriteLine(posicao);
                //Console.WriteLine(posicao.converteParaPosicao());
                //Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                //tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                //tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                //tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));
                //tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(3, 5));

                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.partidaTerminada)
                {

                    Console.Clear();
                    Tela.exibirTabuleiro(partida.tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().converteParaPosicao();


                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().converteParaPosicao();

                    partida.executaMovimento(origem, destino);
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
