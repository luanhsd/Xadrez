using System;
using Xadrez.tabuleiro;

namespace Xadrez.jogo
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "C";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.Peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //ACIMA
            pos.DefinirValores(posicao.linha - 1, posicao.coluna - 2);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //NE
            pos.DefinirValores(posicao.linha - 2, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //DIREITA
            pos.DefinirValores(posicao.linha - 2, posicao.coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //SD
            pos.DefinirValores(posicao.linha - 1, posicao.coluna + 2);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //ABAIXO
            pos.DefinirValores(posicao.linha + 1, posicao.coluna + 2);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //SO
            pos.DefinirValores(posicao.linha + 2, posicao.coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //ESQUERDA
            pos.DefinirValores(posicao.linha + 2, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //ESQUERDA
            pos.DefinirValores(posicao.linha + 1, posicao.coluna - 2);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            return mat;
        }

    }


}
