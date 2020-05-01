using System;
using tabuleiro;
using xadrez_console.xadrez;

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
                for (int c = 0; c < tab.colunas; c++)
                {
                    imprimirPeca(tab.peca(l, c));
                }
                System.Console.WriteLine("  |");
            }
            System.Console.WriteLine("     A B C D E F G H ");
            Console.WriteLine("");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int l = 0; l < tab.linhas; l++)
            {

                System.Console.Write(8 - l + " ");
                System.Console.Write("|  ");
                for (int c = 0; c < tab.colunas; c++)
                {
                    if (posicoesPossiveis[l, c] == true)
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(l, c));
                }
                Console.BackgroundColor = fundoOriginal;
                System.Console.WriteLine("  |");
            }
            System.Console.WriteLine("     A B C D E F G H ");
            Console.WriteLine("");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca p)
        {
            if (p == null)
            {
                Console.Write("- ");
            }
            else
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
                Console.Write(" ");
            }

        }
    }
}
