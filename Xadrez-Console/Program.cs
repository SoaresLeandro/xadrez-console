using tabuleiro;
using xadrez;
using xadrez_Console;

public class Program
{
    public static void Main(string[] args)
    {
        PosicaoXadrez posicaoXadrez = new PosicaoXadrez('b', 4);

        Console.WriteLine(posicaoXadrez.ToPosicao().ToString());

        try
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(Cor.Branca, tabuleiro), new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tabuleiro);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}