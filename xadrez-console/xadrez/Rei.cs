using tabuleiro;
//todas as classes das peças tem relação de herança com a classe Pecas

namespace xadrez
{
//Criar uma classe por tipo de peça, como uma subclasse da classe Peça
    class Rei : Peca 
    {
        //Construtor
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) //repassa a instrução para a classe peça
        {

        }
        
        //retorna a letra R no tabuleiro
        public override string ToString()
        {
            return "R";
        }
    
    }
}
