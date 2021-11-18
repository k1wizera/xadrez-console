using tabuleiro;

namespace tabuleiro
{
    class Posicao
    {
        internal int linha;
        internal int coluna;

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
