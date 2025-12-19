namespace tabuleiro
{
    abstract class Peca
    {
        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QtdeMovimentos = 0;
        }

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; set; }

        public void IncrementarQuantidadeDeMovimentos() => QtdeMovimentos++;

        public abstract bool[,] MovimentosPossiveis();
    }
}
