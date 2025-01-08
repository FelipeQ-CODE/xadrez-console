

namespace tabuleiro
{
     class Tabuleiro
    {
        public int linha { get; set; }
        public int  colunas { get; set; }
        private Peca[,] pecas; //Matriz de peças

        public Tabuleiro(int linha, int colunas) //Construtor
        {
            this.linha = linha; //this é uma referencia para o objeto que está sendo criado
            this.colunas = colunas;
            pecas = new Peca[linha, colunas]; //Instanciando a matriz de peças
        }

        public Peca peca(int linha, int coluna) //Método para retornar a peça
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) //Método para colocar peça no tabuleiro
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
