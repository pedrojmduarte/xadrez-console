namespace tabuleiro
{
    //Classe que representa o tabuleiro com as peças
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        //Peça não pode ser alterada e nem consultada por classes externas
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //Método para retornar a posição da peça
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
