using tabuleiro;

namespace xadrez
{
//Criar uma classe por tipo de peça, como uma subclasse da classe Peça
    class Rei : Peca 
    {
        //Construtor
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }
        
        //retorna a letra R no tabuleiro
        public override string ToString()
        {
            return "R";
        }
    
    }
}
