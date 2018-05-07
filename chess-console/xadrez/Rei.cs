using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao posicao)
        {
            Peca peca = tabuleiro.peca(posicao);
            return peca == null || peca.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[tabuleiro.linhas, tabuleiro.colunas];

            //Posicao posicao = new Posicao(0, 0);

            // verificando posição acima
            posicao.definirValores(posicao.linha - 1, posicao.coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            // verificando posição nordeste
            posicao.definirValores(posicao.linha - 1, posicao.coluna +1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            // verificando posição direita
            posicao.definirValores(posicao.linha, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            // verificando posição sudeste
            posicao.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            // verificando posição abaixo
            posicao.definirValores(posicao.linha + 1, posicao.coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            // verificando posição sudoeste
            posicao.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            // verificando posição esquerda
            posicao.definirValores(posicao.linha, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            // verificando posição noroeste
            posicao.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            return matriz;
        }
    }
}
