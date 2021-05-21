using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте познакомимся, как вас зовут?");
            string questionAboutName = Console.ReadLine();
            Console.WriteLine("Какой у вас знак зодиака?");
            string questionAboutZodiac = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            string questionAboutJob = Console.ReadLine();
            Console.WriteLine($"Вас зовут {questionAboutName}, вы по знаку зодиака {questionAboutZodiac}, ваша работа {questionAboutJob}. ");
            Console.ReadKey();
        }
    }
}
