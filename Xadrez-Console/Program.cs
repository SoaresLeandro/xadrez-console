using tabuleiro;
using Xadrez_Console;

public class Program
{
    public static void Main(string[] args)
    {
        Tabuleiro tabuleiro = new Tabuleiro(8, 8);

        Tela.ImprimirTabuleiro(tabuleiro);

        Console.ReadLine();
    }
}