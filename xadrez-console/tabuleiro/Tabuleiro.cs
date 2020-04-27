using xadrez_console.tabuleiro;

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
            return pecas[pos.Linha, pos.Coluna];
        }

        //METODO PARA COLOCAR PEÇAS NO TABULEIRO
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("A posição ja esta ocupada!");
            }
            validarPosicao(pos);
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        //METODO PARA VALIDAR SE HA UMA PECA NA POSICAO
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return (pecas[pos.Linha, pos.Coluna] != null);
        }

        //METODO PARA VALIDAR A POSICAO 
        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha >= 0 || pos.Linha <= linhas || pos.Coluna >= 0 || pos.Coluna <= colunas)
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
            if (posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida.");
            }
        }


    }
} 

