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

                while (!partida.terminada)
                {
                    Console.Clear();
                    Util.ImprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Util.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.tab.Peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Util.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Util.LerPosicaoXadrez().ToPosicao();
                    partida.ExecutaMovimento(origem, destino);
                }


            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
    
            Console.ReadLine();
        }
    }
}
