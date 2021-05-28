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
            Console.WriteLine("для выхода из  цикла 1, для продолжения 2");
            string goingCycles = Console.ReadLine();
            int numberCycles = 1;

            while (goingCycles == "2")
            {
                Console.WriteLine("для выхода из  цикла 1, для продолжения 2");
                goingCycles = Console.ReadLine();
                numberCycles++;
                Console.WriteLine(numberCycles + " цикл");
            }
            Console.WriteLine("Вы вышли из цикла");
            Console.ReadKey();

        }
    }
}
