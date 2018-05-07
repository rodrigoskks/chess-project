using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "T";
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
            while(tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if(tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.linha = posicao.linha - 1;
            }

            // verificando posição abaixo
            posicao.definirValores(posicao.linha + 1, posicao.coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.linha = posicao.linha + 1;
            }

            // verificando posição direita
            posicao.definirValores(posicao.linha, posicao.coluna + 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.coluna = posicao.coluna + 1;
            }

            // verificando posição esquerda
            posicao.definirValores(posicao.linha, posicao.coluna - 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.coluna = posicao.coluna - 1;
            }

            return matriz;
        }
    }
}
