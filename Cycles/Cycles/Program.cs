using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMessage;
            string userMessage;
            Console.WriteLine("Задайте желаемое количество повторений");
            numberMessage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сообщение которое хотите вывести в консоль");
            userMessage = Console.ReadLine();
            for (int i = 1; i < numberMessage; i++)
            {
                Console.WriteLine(userMessage);
            }
            Console.ReadKey();
        }
    }
}
