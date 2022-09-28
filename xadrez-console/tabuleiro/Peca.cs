//Classe com as características das peças do xadrez
namespace tabuleiro
{
    class Peca
    {
        // As classes com protected, não pode ser modificadas por classes externas
        public Posicao posicao { get; set; } //associando com a classe Posicao, que é uma característica da peça
        public Cor cor { get; protected set; } //alterado somente por ela e pelas suas subclasses
        public int qteMovimentos { get; protected set; } //alterado somente por ela e pelas suas subclasses
        public Tabuleiro tab { get; protected set; } //alterado somente por ela e pelas suas subclasses

        //Construtor inicia com qtde de movimentos 0, pois é a posiçao original.
        //Posição null pois quem vai definir a posição é o método colocarPeca da classe Tabuleiro
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;            
            this.qteMovimentos = 0;
        }



    }
}
