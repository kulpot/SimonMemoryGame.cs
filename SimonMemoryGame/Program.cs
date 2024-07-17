using SimonMemoryGame;
using System;

//UI Building

namespace SimonmemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SimonGame game = new SimonGame();

            while(!game.GameOver)
            {

            }
        }

        private static void displayCurrentRound(SimonGame game)
        {
            Console.Clear();
            foreach(Colors color in game.Colors)
            {
                Console.WriteLine("Round " + game.Colors.Count+": \n"); //Round 1
            }
        }
    }
}