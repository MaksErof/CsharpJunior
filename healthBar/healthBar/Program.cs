using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int value; int maxValue = 30; 
            ConsoleColor barColor = Console.BackgroundColor;
            Random anyValue = new Random();
            Random anyColor = new Random();

            while (true)
            {
                value = anyValue.Next(1, 30);

                ChangeToColor(ref barColor, anyColor);
                DrawBar(value, maxValue, barColor);

                Console.ReadKey();
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color)
        {
            
                Console.SetCursorPosition(52, 10);
                ConsoleColor defaultColor = Console.BackgroundColor;
                string bar = "";

                for (int i = 0; i < value; i++)
                {
                    bar += ' ';
                }
                Console.Write("[");
                Console.BackgroundColor = color;
                Console.Write(bar);
                Console.BackgroundColor = defaultColor;
                bar = "";

                for (int i = value; i < maxValue; i++)
                {
                    bar += ' ';
                }

                Console.Write(bar);
                Console.Write("]");            
        }

        static void ChangeToColor(ref ConsoleColor color, Random numberColor)
        {
            int barNumberColor = numberColor.Next(1, 4);

            switch (barNumberColor)
            {
                case 1:
                    color = ConsoleColor.Red;
                    break;
                case 2:
                    color = ConsoleColor.Blue;
                    break;
                case 3:
                    color = ConsoleColor.Green;
                    break;
            }
        }
        
    }
}
