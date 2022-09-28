namespace tabuleiro
{
    //Classe que representa o tabuleiro com as peças
    class Tabuleiro
    {
        //um tabuleiro tem número de linhas e colunas,no xadrex 8x8, porém, para outros jogos pode mudar
        public int linhas { get; set; }
        public int colunas { get; set; }
        //Matriz de peças
        //Peça não pode ser alterada e nem consultada por classes externas, só o tabuleiro que mexe nelas
        private Peca[,] pecas;

        //construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            //instanciar a matriz de peças de acordo com o n de linhas e colunas
            pecas = new Peca[linhas, colunas];
        }

        //Método para retornar a posição da pe
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //função para colocar uma peça na posição do tabuleiro

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }


    }
}
