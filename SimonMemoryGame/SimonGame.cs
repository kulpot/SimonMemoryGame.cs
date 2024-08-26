using System;
using System.Collections.Generic;
using System.Linq;     
using System.Text;
using System.Threading.Tasks;

// Logic Building

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
                return false;
            }
            else
            {
                //round over / guess is correct
                if(guessPosition == Colors.Count - 1)
                {
                    guessPosition = 0;
                    generateColor();
                    return false;   //means last guess of the round or loss
                }
                //guess is correct but round is not over
                guessPosition++;
                return true;    //means rounds not over keep on guessing
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
