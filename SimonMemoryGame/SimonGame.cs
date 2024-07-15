using System;
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

        public SimonGame()
        {
            Colors = new List<Colors>();
            generateColor();
        }

        public bool MakeGuess(Colors color)
        {
            if (Colors[guessPosition] != color)
            {
                GameOver = true;
            }
        }

        private void generateColor()
        {
            Random ran = new Random();
            int ranColorAsInt = ran.Next(4);
            Colors ranColor = (Colors)ranColorAsInt;

            Colors.Add(ranColor);
        }
    }
}
