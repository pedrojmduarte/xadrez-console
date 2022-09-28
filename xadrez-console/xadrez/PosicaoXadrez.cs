//Classe para representar a posição no contexto do xadrez
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        //construtor
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

    }
}
