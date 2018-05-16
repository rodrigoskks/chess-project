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
<<<<<<< HEAD

=======
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
        private bool podeMover(Posicao posicao)
        {
            Peca peca = tabuleiro.peca(posicao);
            return peca == null || peca.cor != cor;
        }
<<<<<<< HEAD

        public override bool[,] movimentosPossiveis()
=======
        public override bool [,] movimentosPossiveis()
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
        {
            bool[,] matriz = new bool[tabuleiro.linhas, tabuleiro.colunas];

            //Posicao posicao = new Posicao(0, 0);

<<<<<<< HEAD
            // verificando posição acima
=======
            // acima
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            posicao.definirValores(posicao.linha - 1, posicao.coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

<<<<<<< HEAD
            // verificando posição nordeste
=======
            // nordeste
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            posicao.definirValores(posicao.linha - 1, posicao.coluna +1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

<<<<<<< HEAD
            // verificando posição direita
=======
            // direita
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            posicao.definirValores(posicao.linha, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

<<<<<<< HEAD
            // verificando posição sudeste
=======
            // sudeste
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            posicao.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

<<<<<<< HEAD
            // verificando posição abaixo
=======
            // abaixo
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            posicao.definirValores(posicao.linha + 1, posicao.coluna);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

<<<<<<< HEAD
            // verificando posição sudoeste
            posicao.definirValores(posicao.linha + 1, posicao.coluna - 1);
=======
            // sudoeste
            posicao.definirValores(posicao.linha + 1, posicao.coluna -1);
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

<<<<<<< HEAD
            // verificando posição esquerda
            posicao.definirValores(posicao.linha, posicao.coluna - 1);
=======
            // esquerda
            posicao.definirValores(posicao.linha - 1, posicao.coluna);
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

<<<<<<< HEAD
            // verificando posição noroeste
=======
            // noroeste
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            posicao.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
            }

            return matriz;
        }
    }
}
