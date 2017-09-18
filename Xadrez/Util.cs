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
                Console.Write(8 - i + "  ");
                for (int j = 0; j < Tab.colunas; j++)
                {
                    if (Tab.Peca(i, j) == null)
                        Console.Write("- ");
                    else
                    {
                        ImprimirPeca(Tab.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H |");
            Console.WriteLine("-------------------|");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
                Console.Write(peca);
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            
        }
    }
}
