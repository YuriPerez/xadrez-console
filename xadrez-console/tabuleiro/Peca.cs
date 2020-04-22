using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca()
        {
        }
        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qtdeMovimentos = 0;
        }
    }
}
