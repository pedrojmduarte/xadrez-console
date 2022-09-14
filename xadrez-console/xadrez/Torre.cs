using tabuleiro;

namespace xadrez
{
    //Criar uma classe por tipo de peça, como uma subclasse da classe Peça
    class Torre : Peca
    {
        //Construtor
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }
        //retorna a letra R no tabuleiro
        public override string ToString()
        {
            return "T";
        }

    }
}
