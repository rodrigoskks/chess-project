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
                PosicaoXadrez posicao = new PosicaoXadrez('c', 7);
                Console.WriteLine(posicao);
                Console.WriteLine(posicao.converteParaPosicao());

                //    Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                //    tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                //    tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                //    tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

                //    Tela.exibirTabuleiro(tabuleiro);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
