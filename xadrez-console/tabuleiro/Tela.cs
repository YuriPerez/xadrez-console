using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.linhas; l++)
            {
                System.Console.Write("|  ");
                for (int c =0; c < tab.colunas; c++)
                {
                    if (tab.peca(l, c) == null)
                    {
                        System.Console.Write("- ");
                    } else
                    {
                        System.Console.Write(tab.peca(l, c).ToString() + " ");
                    }
                }
                System.Console.WriteLine("  |");
            }
        }
    }
}
