using tabuleiro;
using System;


namespace xadrez
{

    class Rei : Peca
    { //Classe Rei herda de Peca
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) //Construtor Rei
        {
        }
        public override string ToString() //Método ToString
        {
            return "R";
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
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }

            //Nordeste  /
            pos.definirValores(posicao.linha - 1, posicao.coluna +1); //Define os valores da posição
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }

            //Direita 
            pos.definirValores(posicao.linha, posicao.coluna +1); //Define os valores da posição
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }

            //Sudeste \
            pos.definirValores(posicao.linha + 1, posicao.coluna +1); //Define os valores da posição
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }

            //Abaixo

            pos.definirValores(posicao.linha + 1, posicao.coluna); //Define os valores da posição
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }

            //Sudoeste /
            pos.definirValores(posicao.linha , posicao.coluna -1); //Define os valores da posição
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }

            //Esquerda 
            pos.definirValores(posicao.linha - 1, posicao.coluna); //Define os valores da posição
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }

            //Noroeste \
            pos.definirValores(posicao.linha - 1, posicao.coluna -1); //Define os valores da posição
            if (tab.posicaoValida(pos) && podeMover(pos)) //Se a posição for válida e puder mover
            {
                mat[pos.linha, pos.coluna] = true; //A posição é verdadeira
            }
            return mat; //Retorna a matriz
        }
    }
}
