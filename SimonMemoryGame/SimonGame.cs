﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonMemoryGame
{
    class SimonGame
    {
        public bool GameOver { get; private set; } = false;
        public List<Colors> Colors { get; private set; }

        private int guessPosition = 0;

    }
}
