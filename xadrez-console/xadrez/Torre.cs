using System;
using tabuleiro;

namespace xadrez
{

     class Torre :Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) //Construtor Torre
        {
        }
        public override string ToString() //Método ToString
        {
            return "T";
        }
    }
}
