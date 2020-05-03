using xadrez_console;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro()
        {
        }
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //METODO QUE RETORNA UM PECA DO TABULEIRO
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        //SOBRECARGA
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        //METODO PARA COLOCAR PEÇAS NO TABULEIRO
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("A posição ja esta ocupada!");
            }
            validarPosicao(pos);
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        //METODO PARA VALIDAR SE HA UMA PECA NA POSICAO
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return (pecas[pos.linha, pos.coluna] != null);
        }

        //METODO PARA VALIDAR A POSICAO 
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //METODO PARA GERAR UME EXECAO CASO A POSICAO SEJA INVALIDA
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida.");
            }
        }


    }
} 

