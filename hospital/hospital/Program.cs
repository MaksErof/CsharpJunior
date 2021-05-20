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
            double timeOfReceipt = 10;
            Console.WriteLine("Введите количество человек перед вами в очереди");
            double numbersHumans = Convert.ToDouble(Console.ReadLine());
            double waitingTime = numbersHumans * timeOfReceipt / 60;
            double waitingTimeHours = Math.Truncate(waitingTime);
            double waitingTimeMinutes = (waitingTime - (waitingTimeHours)) * 60;
            Console.WriteLine($"Вы отстоите в очереди {waitingTimeHours} часа и {waitingTimeMinutes} минут");
            Console.ReadKey();

        }
    }
}
