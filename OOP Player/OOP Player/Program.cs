using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int health = randomNumber.Next(0,100);
            int damage = randomNumber.Next(20,50);
            int armor = randomNumber.Next(0,10);

            Player player = new Player(health, damage, armor);
            player.ShowStats();

            Console.ReadKey();
        }
    }

    class Player
    {
       private int _health;
       private int _damage;
       private int _armor;
        
        public Player(int health, int damage, int armor)
        {
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"ХП {_health}, Урон {_damage}, Броня {_armor}");
        }
    }
}
