

namespace Tabuleiro
{
     class Peca
    {   
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int qteMovemtnso { get;protected  set; }

        public Tabuleiro tab { get;protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) //Construtor
        {
            this.posicao = posicao; //this é uma referencia para o objeto que está sendo criado
            this.tab = tab; 
            this.cor = cor;
            this.qteMovemtnso = 0;
        }
    }
}
