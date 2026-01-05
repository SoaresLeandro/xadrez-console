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

        public bool ExistemMovimentosPossiveis()
        {
            bool[,] matriz = MovimentosPossiveis();

            for(int i = 0; i < Tabuleiro.Linhas; i ++)
            {
                for(int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (matriz[i, j])
                        return true;
                }
            }

            return false;
        }

        public bool PodeMoverPara(Posicao posicao) => MovimentosPossiveis()[posicao.Linha, posicao.Coluna];

        public abstract bool[,] MovimentosPossiveis();
    }
}
