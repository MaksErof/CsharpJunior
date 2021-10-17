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
            Random rand = new Random();
            int health = rand.Next(0,100);
            int damage = rand.Next(20,50);
            int armor = rand.Next(0,10);

            Player player = new Player(health, damage, armor);
            player.ShowStats();

            Console.ReadKey();
        }
    }

    class Player
    {
       private int Health;
       private int Damage;
       private int Armor;
        
        public Player(int health, int damage, int armor)
        {
            Health = health;
            Damage = damage;
            Armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"ХП {Health}, Урон {Damage}, Броня {Armor}");
        }
    }
}
