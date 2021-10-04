using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maps
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map;
            char playerSymbol;
            int playerPositionX = 5, playerPositionY = 5;
            int playerMoveX = 0, playerMoveY = 0;
            Console.CursorVisible = false;

            DrawMapAndPlayer(out map, playerPositionX, playerPositionY, out playerSymbol);

            while (true)
            {
                movementOfPlayer(map, playerSymbol, ref playerPositionX, ref playerPositionY, playerMoveX, playerMoveY);
            }
        }

        static void DrawMapAndPlayer(out char[,] map, int playerPositionX, int playerPositionY, out char playerSymbol)
        {           
            playerSymbol = '*';            

                map = new char [14,21]
                {
                {'@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@'},
                {'@', ' ', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', '@'},
                {'@', ' ', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', ' ', '@'},
                {'@', ' ', '@', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', ' ', '@'},
                {'@', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', ' ', '@', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', '@', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '@', ' ', '@', ' ', '@'},
                {'@', ' ', '@', ' ', ' ', '@', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '@', ' ', '@', ' ', '@'},
                {'@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@', '@'},
                };

                for(int i = 0; i < map.GetLength(0); i++)
                {
                    for(int j = 0; j <map.GetLength(1); j++)
                    {
                        Console.Write(map[i,j]);
                    }
                    Console.WriteLine(); 
                }
             Console.SetCursorPosition(playerPositionX, playerPositionY);
             Console.Write(playerSymbol);
        }

        static void movementOfPlayer(char [,] map, char playerSymbol,ref int playerPositionX,ref int playerPositionY, int playerMoveX, int playerMoveY)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        playerMoveX = -1; playerMoveY = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        playerMoveX = 1; playerMoveY = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerMoveX = 0; playerMoveY = -1;
                        break;
                    case ConsoleKey.RightArrow:
                        playerMoveX = 0; playerMoveY = 1;
                        break;
                }
                if (map[playerPositionX + playerMoveX, playerPositionY + playerMoveY] != '@')
                {
                    Console.SetCursorPosition(playerPositionY, playerPositionX);
                    Console.Write(" ");

                    playerPositionX += playerMoveX;
                    playerPositionY += playerMoveY;

                    Console.SetCursorPosition(playerPositionY, playerPositionX);
                    Console.Write(playerSymbol);
                }
            }
        }
    }
}
