using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endless_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string goingCycles;                                                                    
            for (int numberCycles = 1; ; numberCycles++ )
            {
                Console.WriteLine("Для продолжения цикла введите go, для выхода exit");
                goingCycles = Console.ReadLine();

                if (goingCycles == "go")
                {
                    Console.WriteLine(numberCycles + " цикл");
                }
                else 
                {
                    break;                    
                }                                                                                           
            }
            Console.WriteLine("Вы вышли из цикла");
            Console.ReadKey();
        }

    }
}
