using tabuleiro;

namespace xadrez
{
    //Criar uma classe por tipo de peça, como uma subclasse da classe Peça
    class Torre : Peca
    {
        //Construtor
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        //retorna a letra R no tabuleiro
        public override string ToString()
        {
            return "T";
        }

    }
}
