using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuCreation = "to begin";
            string userLogin;
            int userPassword;
            string consoleColor;
            int consoleSize;

            while (menuCreation != "exit")
            {   
                
                Console.WriteLine("Для изменения ввода имени введите 1, для ввода пароля 2\nИзменить цвет консоли можно перейдя в меню 3\nМеню 4 позволит изменить размеры консоли\nДля выхода введите exit");
                menuCreation = Console.ReadLine();
                
                switch (menuCreation)
                {

                    case ("1"):
                        Console.WriteLine("Введите логин, допускаются английский и русский ввод");
                        userLogin = Console.ReadLine();
                        break;

                    case ("2"):
                        Console.WriteLine("Введите пароль, пароль должен состоять из цифр");
                        userPassword = Convert.ToInt32(Console.ReadLine());
                        break;

                    case ("3"):
                        Console.WriteLine("Выберите цвет консоли\n1 красный цвет\n2 жёлтый цвет\n3 серый цвет");
                        consoleColor = Console.ReadLine();

                        if (consoleColor == "1")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        }
                        else if (consoleColor == "2")
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        else if (consoleColor == "3")
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;                            
                            break;
                        }                        
                        break;

                    case ("4"):
                        Console.WriteLine("Выберите высоту и ширину консоли");
                        consoleSize = Convert.ToInt32(Console.ReadLine());
                        Console.WindowHeight = consoleSize;                        
                        consoleSize = Convert.ToInt32(Console.ReadLine());
                        Console.WindowWidth = consoleSize;
                        break;                        
                }
                Console.Clear();                
            }            
            Console.ReadKey();
        }
    }
}
