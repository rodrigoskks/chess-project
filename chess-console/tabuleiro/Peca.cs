using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            quantidadeMovimentos = 0;
        }

        public void incrementarQuantidadeMovimentos()
        {
            quantidadeMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] matriz = movimentosPossiveis();
<<<<<<< HEAD
            for(int i=0; i<tabuleiro.linhas; i++)
            {
                for(int j=0; j<tabuleiro.colunas; j++)
                {
                    if(matriz[i,j])
=======

            for(int i=0; i < tabuleiro.linhas; i++)
            {
                for (int j=0; j < tabuleiro.colunas; j++)
                {
                    if (matriz[i, j])
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
                    {
                        return true;
                    }
                }
            }
<<<<<<< HEAD
            return false;
        }

        public abstract bool[,] movimentosPossiveis();
=======
            return false;       
        }
        public bool podeMoverPara(Posicao posicao)
        {
            return movimentosPossiveis()[posicao.linha, posicao.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
        

>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
    }
}
