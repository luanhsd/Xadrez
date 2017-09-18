using System;
using Xadrez.tabuleiro;
using Xadrez.jogo;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
