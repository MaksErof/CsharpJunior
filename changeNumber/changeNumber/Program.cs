using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 7;
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(startNumber += 7);
            }
            Console.ReadKey();
        }
    }
}
