using System;
using Xadrez.tabuleiro;
using Xadrez.jogo;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Util.ImprimirTabuleiro(partida.tab);
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
