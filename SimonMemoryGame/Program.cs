﻿using SimonMemoryGame;
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

                System.Threading.Thread.Sleep(1000);    // 1sec delay

                switch(color)
                {
                    case Colors.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Colors.Yellow:
                        break;
                }

                Console.WriteLine(color); 
            }
        }
    }
}