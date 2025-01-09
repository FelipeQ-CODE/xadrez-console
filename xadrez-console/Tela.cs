using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {

            for (int i = 0; i < tab.linha; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }
        public static PosicaoXadrez lerPosicaoXadrez() //Método para ler a posição do xadrez
        {
            string s = Console.ReadLine(); // Lê a string
            char coluna = s[0]; //Pega a primeira letra
            int linha = int.Parse(s[1] + ""); //Pega o segundo caractere
            return new PosicaoXadrez(coluna, linha); //Retorna a posição
        }

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