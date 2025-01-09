

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int qteMovemtnso { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) //Construtor
        {
            this.posicao = null; //this é uma referencia para o objeto que está sendo criado
            this.tab = tab;
            this.cor = cor;
            this.qteMovemtnso = 0;
        }
        public void incrementarQteMovimentos()
        {
            qteMovemtnso++;
        }
        public abstract bool[,] movimentosPossiveis(); //Método abstrato


    }
}

