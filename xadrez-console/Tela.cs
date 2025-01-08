using System;
using tabuleiro;

namespace xadrez_console
{
     class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) //Método para imprimir o tabuleiro
        {
            for (int i = 0; i < tab.linha; i++) //Percorre as linhas
            {
                for (int j = 0; j < tab.colunas; j++) 
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
