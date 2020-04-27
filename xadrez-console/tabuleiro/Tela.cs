using System;
using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.linhas; l++)
            {
                System.Console.Write(8 - l + " ");
                System.Console.Write("|  ");
                for (int c =0; c < tab.colunas; c++)
                {
                    if (tab.peca(l, c) == null)
                    {
                        System.Console.Write("- ");
                    } else
                    {
                        imprimirPeca(tab.peca(l, c));
                        Console.Write(" ");
                    }
                }
                System.Console.WriteLine("  |");
            }
            System.Console.WriteLine("     A B C D E F G H ");
        }
        public static void imprimirPeca(Peca p)
        {
            if (p.cor == Cor.Branca)
            {
                System.Console.Write(p);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(p);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
