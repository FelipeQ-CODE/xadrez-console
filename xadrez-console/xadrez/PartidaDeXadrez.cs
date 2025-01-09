using System;
using tabuleiro;
using xadrez_console;


namespace xadrez
{
     class PartidaDeXadrez
    {
        public Tabuleiro tab { get;private set; } //Atributo tab do tipo Tabuleiro
        private int turno; //Atributo turno do tipo inteiro
        private Cor jogadorAtual; //Atributo jogadorAtual do tipo Cor
        public bool terminada { get; private set; } //Atributo terminada do tipo booleano

        public PartidaDeXadrez()  //Construtor
        {
            
            tab = new Tabuleiro(8, 8); //Instancia um novo tabuleiro
            turno = 1; //Turno começa em 1
            jogadorAtual = Cor.Branca; //Jogador atual começa com a cor branca
            terminada = false; //A partida não está terminada
            colocarPecas(); //Chama o método colocarPecas


        }
        public void executaMovimento(Posicao origem, Posicao destino) //
        {
            Peca p = tab.retirarPeca(origem); //Retira a peça da posição de origem
            p.incrementarQteMovimentos(); //Incrementa a quantidade de movimentos
            Peca pecaCapturada = tab.retirarPeca(destino); //Retira a peça da posição de destino
            tab.colocarPeca(p, destino); //Coloca a peça na posição de destino
        }
        private void colocarPecas() //Colocando as Peças em suas devidas posições
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());
        }
    }
}
