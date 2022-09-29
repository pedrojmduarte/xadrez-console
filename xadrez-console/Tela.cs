//classe que imprime o tabuleiro na tela. Está na camada de aplicação
using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        //método estático (São membros que fazem sentido independentemente de objetos. Não precisam de objeto para serem chamados.São chamados a partir do próprio nome da classe.
        //recebe o tabuleiro e o imprime na tela
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
           
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    //Se a peça na posição i,j for igual a nula, imprime traço, se não imprime a peça
                    if (tab.peca(i,j)==null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                                    
                }
                //Para quebrar a linha após imprimir todas as posiçoes da linha
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        //ler posição passada pelo usuário

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);

        }



        //método para imprimir peças coloridas
        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);

            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
