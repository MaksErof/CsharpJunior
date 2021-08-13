using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;

            Console.WriteLine("Пользователь, введите число");
            CheckTheNumber(out userNumber);
            Console.WriteLine("Введено число");
            Console.ReadKey();
        }
        static void CheckTheNumber(out int number)
        {
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введено неверное число, впишите заново.");
            }
        }
    }
}
