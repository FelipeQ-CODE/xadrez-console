

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

        public Peca peca (Posicao pos) //Sobrecarga do método peca
        {
            return pecas[pos.linha, pos.coluna]; //Sobrecarga do método peca
        }
        public bool existePeca(Posicao pos) //Método para verificar se existe peça
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) //Método para colocar peça no tabuleiro
        {
            if (existePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição!"); //Lança uma exceção
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        
        public Peca retirarPeca(Posicao pos) { //Método para retirar peça do tabuleiro
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos); //Pega a peça na posição
            aux.posicao = null; //A posição da peça é nula
            pecas[pos.linha, pos.coluna] = null; //A posição da peça é nula
            return aux; //Retorna a peça
        }

        public bool posicaoValida(Posicao pos) //Método para verificar se a posição é válida
        {
            if (pos.linha < 0 || pos.linha >= linha || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos) //Método para validar a posição
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!"); //Lança uma exceção
            }
        }
    }
}
