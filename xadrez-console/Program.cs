using System;
using System.Text;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //RichTextBox console = new RichTextBox();
           // console.Font = new Font("Consolas", 12);

            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));


            Tela.imprimirTabuleiro(tab);
            
            Console.WriteLine();


        }
    }
}
