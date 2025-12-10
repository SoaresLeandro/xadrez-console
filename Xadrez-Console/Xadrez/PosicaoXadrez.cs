using tabuleiro;

namespace xadrez
{
    public class PosicaoXadrez
    {
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public char Coluna { get; set; }
        public int Linha { get; set; }

        public Posicao ToPosicao() => new Posicao(8 - Linha, Coluna - 'a');

        public override string ToString() => $"{Coluna}{Linha}";
    }
}
