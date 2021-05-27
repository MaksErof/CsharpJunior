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
                Console.WriteLine("Для продолжения цикла введите go, для выхода exit");
                goingCycles = Console.ReadLine();
                if (goingCycles == "go")
                {
                    Console.WriteLine(i + " цикл");
                }
                else if (goingCycles == "exit")
                {
                    break;
                    
                }
                
                                                                           
            }
            Console.WriteLine("Вы вышли из цикла");
            Console.ReadKey();
        }

    }
}
