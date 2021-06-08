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
            int numberToChange;
            for (numberToChange = 7; numberToChange <= 98; numberToChange += 7)
            {
                Console.WriteLine(numberToChange);
            }
            Console.ReadKey();
        }
    }
}
