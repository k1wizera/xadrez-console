using System;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            if (cor == Cor.Branca)
            {
                return "\u265C"; 

            }
            return "\u2656";
        }
    }
}
