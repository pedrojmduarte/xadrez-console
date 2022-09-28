namespace tabuleiro
{
    //Classe que representa o tabuleiro com as peças
    class Tabuleiro
    {
        //um tabuleiro tem número de linhas e colunas,no xadrex 8x8, porém, para outros jogos pode mudar
        public int linhas { get; set; }
        public int colunas { get; set; }
        //Matriz de peças
        //Peça não pode ser alterada e nem consultada por classes externas, só o tabuleiro que mexe nelas
        private Peca[,] pecas;

        //construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            //instanciar a matriz de peças de acordo com o n de linhas e colunas
            pecas = new Peca[linhas, colunas];
        }

        //Método para retornar a posição da peça (tipo dela é Peca)
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //criar sobrecarga do método peca, recebendo posição pos, inves de linha e coluna

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        
        //método se existe uma peça na posição
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //função para colocar uma peça p na posição pos do tabuleiro
        //só pode colocar peça, aonde não tem nenhuma peça
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            
            pecas[pos.linha, pos.coluna] = p;
            //associa a posição pos ao atributo posição da Peça p
            p.posicao = pos;
        }

        //método para testar se uma posição é válida
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha<0 || pos.linha >=linhas || pos.coluna<0 || pos.coluna>= colunas)
            {
                return false;
            }
            return true; // não precisa colocar else, pois o return quebra a condição
        }

        //método para validar uma posição e lançar uma exceção
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
