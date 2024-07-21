using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonMemoryGame
{
    public static class StringToColorConverter
    {
        public static Colors Convert(string color)
        {
            switch(color.ToLower()) // convert uppercase color to lower
            {
                case "yellow":
                    return Colors.Yellow;
                case "blue":
                    return Colors.Blue;
                case "green":
                    break;
                case "red":
                    break;

            }
        }
    }
}
