namespace tabuleiro
{
    //Classe com as informações das posições no tabuleiro
    class Posicao
    {
        //posição da linha e posição da coluna
        public int linha { get; set; } //podem ser alterados e acessados por qualquer classes
        public int coluna { get; set; }

        //construtor
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
