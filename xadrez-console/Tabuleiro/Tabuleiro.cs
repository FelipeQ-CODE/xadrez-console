

namespace Tabuleiro
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

    }
}
