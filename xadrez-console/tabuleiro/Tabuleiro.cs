namespace tabuleiro
{
    //Classe que representa o tabuleiro com as peças
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        //Peça não pode ser alterada e nem consultada por classes externas
        public Peca[,] pecas;

        //construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
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
