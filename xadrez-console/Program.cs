using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) //Enquanto a partida não estiver terminada
                {
                    Console.Clear(); //Limpa a tela
                    Tela.imprimirTabuleiro(partida.tab); //Imprime o tabuleiro

                    Console.WriteLine(); //Pula uma linhaD
                    Console.Write("Origem: "); //Escreve na tela
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao(); //Lê a posição de origem
                    Console.Write("Destino: "); //Escreve na tela
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao(); ///Lê a posição de destino

                    partida.executaMovimento(origem, destino); //Executa o movimento
                }

                Tela.imprimirTabuleiro(partida.tab); //Imprime o tabuleiro


            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
      
            }

            Console.ReadLine();
        }
    }
}