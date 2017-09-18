﻿using System;
using Xadrez.tabuleiro;

namespace Xadrez.jogo
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }


}
