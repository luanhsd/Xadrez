using System;
using System.Collections.Generic;
using Xadrez.tabuleiro;
using Xadrez.jogo;

namespace Xadrez
{
    class Util
    {

        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            if (!partida.terminada)
            {
                Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                if (partida.xeque)
                    Console.WriteLine("XEQUE!!!");
            }
            else
            {
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine("Vencedor: " + partida.jogadorAtual);
            }
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("PEÇAS CAPTURADAS: ");
            Console.Write("BRANCAS: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.Write("PRETAS: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
        }

        public static void ImprimirConjunto(HashSet<Peca> capturadas)
        {
            Console.Write("[");
            foreach (Peca x in capturadas)
            {
                ConsoleColor aux = Console.ForegroundColor;
                if (x.cor == Cor.Preta)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(x + " ");
                Console.ForegroundColor = aux;
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static void ImprimirTabuleiro(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.linhas; i++)
            {
                Console.Write(8 - i + "  ");
                for (int j = 0; j < Tab.colunas; j++)
                {
                    ImprimirPeca(Tab.Peca(i, j));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H |");
            Console.WriteLine("-------------------|");
        }

        public static void ImprimirTabuleiro(Tabuleiro Tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor newFundo = ConsoleColor.DarkGray;

            for (int i = 0; i < Tab.linhas; i++)
            {
                Console.Write(8 - i + "  ");
                for (int j = 0; j < Tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                        Console.BackgroundColor = newFundo;
                    else
                        Console.BackgroundColor = fundoOriginal;

                    ImprimirPeca(Tab.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H |");
            Console.WriteLine("-------------------|");
        }



        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
                Console.Write("- ");
            else
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
                Console.Write(" ");
            }

        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
