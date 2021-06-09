using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secret_message
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPassword;
            string secretMessage = "Настало лето";
            string wrongPassword = "Не верный пароль, попробуйте ещё раз";
            string checkPassword;

            Console.WriteLine("Задайте пароль");
            userPassword = Console.ReadLine();

            for(int i = 1; i <= 3 ; i++)
            {
                Console.WriteLine("Введите пароль, для вывода сообщения");
                checkPassword = Console.ReadLine();

                if (checkPassword == userPassword)
                {

                    Console.WriteLine(secretMessage);
                    break;
                }
                else if(checkPassword != userPassword)
                {

                    Console.WriteLine(wrongPassword);
                }

                if (i==3)
                {

                    Console.Clear();
                    Console.WriteLine("Вы исчерпали лимит на ввод пароля");
                }
            }
            Console.ReadKey();
        }
    }
}
