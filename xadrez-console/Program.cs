using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 2);
            Console.WriteLine(p);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            Console.WriteLine("");
        }
    }
}
