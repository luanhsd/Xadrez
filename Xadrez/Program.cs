﻿using System;
using Xadrez.tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro Tab;

            Tab = new Tabuleiro(8,8);

            Console.WriteLine("Tabuleiro: " + Tab);

            Console.ReadLine();
        }
    }
}
