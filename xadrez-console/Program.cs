using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 2);
            Console.WriteLine(p);

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 1));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 4));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 1));


                Tela.imprimirTabuleiro(tab);
                Console.WriteLine("");

                PosicaoXadrez pos = new PosicaoXadrez('c', 6);
                Console.WriteLine(pos.ToString());
                Console.WriteLine(pos.toPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
