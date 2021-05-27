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
            for (int i = 1; ; i++ )
            {
                Console.WriteLine("Для продолжения цикла введите 1, для выхода 2");
                goingCycles = Console.ReadLine();
                if (goingCycles == "1")
                {
                    Console.WriteLine(i + " цикл");
                }
                else if (goingCycles == "2")
                {
                    break;
                    
                }
                
                                                                           
            }
            Console.WriteLine("Вы вышли из цикла");
            Console.ReadKey();
        }

    }
}
