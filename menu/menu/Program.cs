﻿using System;
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
            string changeConsole;
            string userLogin;
            int enterPassword;
            string consoleColor;
            int consoleSizeHeight;
            int consoleSizeWidth;            
                        
            Console.WriteLine("Для редактирования консоли введите go, для выхода exit");
            changeConsole = Console.ReadLine();            

            while (changeConsole != "exit")
            {
                Console.WriteLine("Для изменения ввода имени введите 1, для ввода пароля 2\nИзменить цвет консоли можно перейдя в меню 3\nМеню 4 позволит изменить размеры консоли\nДля выхода введите exit");
                changeConsole = Console.ReadLine();
                
                switch (changeConsole)
                {
                    case ("1"):

                        Console.WriteLine("Введите логин, допускаются английский и русский ввод");
                        userLogin = Console.ReadLine();
                        break;

                    case ("2"):

                        Console.WriteLine("Введите пароль, пароль должен состоять из цифр");
                        enterPassword = Convert.ToInt32(Console.ReadLine());
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

                        Console.WriteLine("Выберите ширину консоли");
                        consoleSizeHeight = Convert.ToInt32(Console.ReadLine());
                        Console.WindowHeight = consoleSizeHeight;
                        Console.WriteLine("Выберите высоту консоли");
                        consoleSizeWidth = Convert.ToInt32(Console.ReadLine());
                        Console.WindowWidth = consoleSizeWidth;

                        break;                        
                }
                Console.Clear();                
            }            
            Console.ReadKey();
        }
    }
}