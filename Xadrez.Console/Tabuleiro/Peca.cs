namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; } 

        public Peca(Cor cor,Tabuleiro tab)
        {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
        }
    }
}
