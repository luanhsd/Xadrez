namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao PosicaoAtual { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao PosicaoAtual, Cor CorPeca, Tabuleiro Tab)
        {
            this.PosicaoAtual = PosicaoAtual;
            this.CorPeca = CorPeca;
            this.QtdMovimentos = 0;
            this.Tab = Tab;
        }
    }
}
