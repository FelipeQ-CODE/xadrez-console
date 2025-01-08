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
    }
}
