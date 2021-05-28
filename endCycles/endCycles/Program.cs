using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для продолжения введите цикла go, для выхода exit");
            string goingCycles = Console.ReadLine();
            int numberCycles = 1;
            Console.WriteLine(numberCycles + " цикл");

            while (goingCycles == "go")
            {
                Console.WriteLine("Для продолжения введите цикла go, для выхода exit");
                goingCycles = Console.ReadLine();
                numberCycles++;
                if(goingCycles == "exit")
                {
                    break;
                }
                Console.WriteLine(numberCycles + " цикл");
            }
            Console.WriteLine("Вы вышли из цикла");
            Console.ReadKey();

        }
    }
}
