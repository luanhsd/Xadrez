using System;
using Xadrez.tabuleiro;

namespace Xadrez
{
    class Util
    {
        public static void ImprimirTabuleiro(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.linhas; i++)
            {
                for (int j = 0; j < Tab.colunas; j++)
                {
                    if (Tab.Peca(i, j) == null)
                        Console.Write("- ");
                    else
                        Console.Write(Tab.Peca(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
