using System;
using tabuleiro;

namespace xadrez
{

    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) //Construtor Torre
        {
        }
        public override string ToString() //Método ToString
        {
            return "T";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos); //Pega a peça na posição pos
            return p == null || p.cor != cor; //Se a peça for nula ou a cor da peça for diferente da cor do rei
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linha, tab.colunas]; //Cria uma matriz de booleanos com o tamanho do tabuleiro

            Posicao pos = new Posicao(0, 0); //Instancia uma posição

            //ACIMA
            pos.definirValores(posicao.linha - 1, posicao.coluna); //Define os valores da posição
            while (tab.posicaoValida(pos) && podeMover(pos)) //Enquanto a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Se a peça na posição for diferente da cor da torre
                {
                    break; //Sai do loop
                }
                pos.linha = pos.linha - 1; //A posição da linha é decrementada
            }

            //Abaixo 
            pos.definirValores(posicao.linha + 1, posicao.coluna); //Define os valores da posição
            while (tab.posicaoValida(pos) && podeMover(pos)) //Enquanto a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Se a peça na posição for diferente da cor da torre
                {
                    break; //Sai do loop
                }
                pos.linha = pos.linha + 1; //A posição da linha é decrementada
            }

            //A Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1); //Define os valores da posição
            while (tab.posicaoValida(pos) && podeMover(pos)) //Enquanto a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Se a peça na posição for diferente da cor da torre
                {
                    break; //Sai do loop
                }
                pos.coluna = pos.coluna + 1; //A posição da linha é decrementada
            }

            // A Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1); //Define os valores da posição
            while (tab.posicaoValida(pos) && podeMover(pos)) //Enquanto a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) //Se a peça na posição for diferente da cor da torre
                {
                    break; //Sai do loop
                }
                pos.coluna = pos.coluna - 1; //A posição da linha é decrementada
            }
            return mat; //Retorna a matriz
        }
    }
}
