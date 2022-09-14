//Classe com as características das peças do xadrez

namespace tabuleiro
{
    class Peca
    {
        // As classes com protected, não pode ser modificadas por classes externas
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //Construtor inicia com qtde de movimentos 0, pois é a posiçao original.
        //Posição null pois não sabe qual é a posição
        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }



    }
}
