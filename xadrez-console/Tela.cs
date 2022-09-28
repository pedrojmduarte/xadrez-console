//classe que imprime o tabuleiro na tela. Está na camada de aplicação
using System;
using tabuleiro;

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
                for (int j = 0; j < tab.colunas; j++)
                {
                    //Se a peça na posição i,j for igual a nula, imprime traço, se não imprime a peça
                    if (tab.peca(i,j)==null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                                    
                }
                //Para quebrar a linha após imprimir todas as posiçoes da linha
                Console.WriteLine();
            }

        }
    }
}
