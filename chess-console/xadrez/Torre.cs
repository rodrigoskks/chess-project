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
<<<<<<< HEAD
            return peca == null || peca.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[tabuleiro.linhas, tabuleiro.colunas];

            //Posicao posicao = new Posicao(0, 0);

            // verificando posição acima
=======
            return peca == null || peca.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[tabuleiro.linhas, tabuleiro.colunas];
           // Posicao posicao = new Posicao(0, 0);

            // acima
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
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

<<<<<<< HEAD
            // verificando posição abaixo
=======
            // abaixo
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
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

<<<<<<< HEAD
            // verificando posição direita
            posicao.definirValores(posicao.linha, posicao.coluna + 1);
=======
            // direita
            posicao.definirValores(posicao.linha, posicao.coluna +1);
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.coluna = posicao.coluna + 1;
            }

<<<<<<< HEAD
            // verificando posição esquerda
            posicao.definirValores(posicao.linha, posicao.coluna - 1);
=======
            // esquerda
            posicao.definirValores(posicao.linha, posicao.coluna -1);
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
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
<<<<<<< HEAD
=======

>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
    }
}
