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
            int userNumber = 0;

            Console.WriteLine("Пользователь, введите число");
            userNumber = CheckTheNumber(userNumber);
            Console.WriteLine("Введено число" +  " " + userNumber);
            Console.ReadKey();
        }
        static int CheckTheNumber(int number)
        {
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введено неверное число, впишите заново.");
            }
            return number;
        }
    }
}
