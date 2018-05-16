using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
<<<<<<< HEAD
        public int turno { get; protected set; }
=======
        public int turno { get; private set; }
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
        public Cor jogadorAtual { get; private set; }
        public bool partidaTerminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            partidaTerminada = false;
<<<<<<< HEAD
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
=======

            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();

>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = tabuleiro.retirarPeca(origem);
            peca.incrementarQuantidadeMovimentos();
            Peca pecaCapturada = tabuleiro.retirarPeca(destino);
            tabuleiro.colocarPeca(peca, destino);
            if (pecaCapturada != null)
            {
<<<<<<< HEAD
                capturadas.Add(peca);
            }
        }



        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao posicao)
        {
            if (tabuleiro.peca(posicao) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida.");
            }
            if (jogadorAtual != tabuleiro.peca(posicao).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua.");
            }
            if (!tabuleiro.peca(posicao).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida.");
            }
        }

        public void mudaJogador()
=======
                capturadas.Add(pecaCapturada);
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoOrigem(Posicao posicao)
        {
            if (tabuleiro.peca(posicao) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida.");
            }
            if (jogadorAtual != tabuleiro.peca(posicao).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua.");
            }
            if (!tabuleiro.peca(posicao).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida.");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tabuleiro.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida.");
            }
        }

        private void mudaJogador()
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }
<<<<<<< HEAD

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> auxiliar = new HashSet<Peca>();
            foreach (Peca peca in capturadas)
            {
                if (peca.cor == cor)
                {
                    auxiliar.Add(peca);
                }
            }
            return auxiliar;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> auxiliar = new HashSet<Peca>();
            foreach (Peca peca in pecas)
            {
                if (peca.cor == cor)
                {
                    auxiliar.Add(peca);
                }
            }
            auxiliar.ExceptWith(pecasCapturadas(cor));
            return auxiliar;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            tabuleiro.colocarPeca(peca, new PosicaoXadrez(coluna, linha).converteParaPosicao());
            pecas.Add(peca);
        }

        private void colocarPecas()
        {
            colocarNovaPeca('c', 1, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('c', 2, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 2, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 2, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 1, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 1, new Rei(tabuleiro, Cor.Branca));


            colocarNovaPeca('c', 7, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('c', 8, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 7, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('e', 7, new Torre(tabuleiro, Cor.Preta));
=======

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> auxiliar = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    auxiliar.Add(x);
                }
            }
            return auxiliar;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> auxiliar = new HashSet<Peca>();
            foreach (Peca x in pecas)
            {
                if (x.cor == cor)
                {
                    auxiliar.Add(x);
                }
            }
            auxiliar.ExceptWith(pecasCapturadas(cor));
            return auxiliar;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            tabuleiro.colocarPeca(peca, new PosicaoXadrez(coluna, linha).converteParaPosicao());
            pecas.Add(peca);
        }

        private void colocarPecas()
        {
            //colocarNovaPeca('c', 1, new Torre(tabuleiro, Cor.Branca));
            //colocarNovaPeca('c', 2, new Torre(tabuleiro, Cor.Branca));
            //colocarNovaPeca('d', 2, new Torre(tabuleiro, Cor.Branca));
            //colocarNovaPeca('e', 2, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 1, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 1, new Rei(tabuleiro, Cor.Branca));

            //colocarNovaPeca('c', 7, new Torre(tabuleiro, Cor.Preta));
            //colocarNovaPeca('c', 8, new Torre(tabuleiro, Cor.Preta));
            //colocarNovaPeca('d', 7, new Torre(tabuleiro, Cor.Preta));
            //colocarNovaPeca('e', 7, new Torre(tabuleiro, Cor.Preta));
>>>>>>> 1f9da163b327327daa1726d9fbdaad0c81379d77
            colocarNovaPeca('e', 8, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 8, new Rei(tabuleiro, Cor.Preta));
        }
    }
}
