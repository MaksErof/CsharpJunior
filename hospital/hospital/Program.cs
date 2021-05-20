using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOfReceipt = 10;
            Console.WriteLine("Введите количество человек перед вами в очереди");
            int numbersHumans = Convert.ToInt32(Console.ReadLine());
            int waitingTime = numbersHumans * timeOfReceipt;
            Console.WriteLine($"Вы отстоите в очереди {waitingTime} минут");
            Console.ReadKey();

        }
    }
}
