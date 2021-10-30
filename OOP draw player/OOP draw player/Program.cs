using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_draw_player
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderingPlayer rendering = new RenderingPlayer();
            Player Player = new Player(55,15);

            rendering.DrawPlayer(Player.PositionX, Player.PositionY);
           
            Console.ReadKey();
        }
    }

    class RenderingPlayer
    {
        public void DrawPlayer(int x, int y, char playerSymbol = '*')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerSymbol);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public Player(int x,int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
