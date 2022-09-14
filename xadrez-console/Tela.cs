using System;
using tabuleiro;

namespace xadrez_console
{
    //Classe para imprimir o tabuleiro na camada de apresentação
    class Tela
    {
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
