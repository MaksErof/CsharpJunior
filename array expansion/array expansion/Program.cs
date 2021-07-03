using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_expansion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1];
            int[] extendedArray;
            bool arraysWork = true;
            string userMessage;
            int arraysNumber = 0;
            int arraySum = 0;

            
            while (arraysWork)
            {
                Console.WriteLine("Чтобы заполнить массив введите любое число, для суммирования массива введите sum," +
                " для выхода введите exit");
                extendedArray = new int[array.Length + 1];
                Console.Write("Ввод: ");
                userMessage = Console.ReadLine(); 
                
                if (userMessage != "exit" && userMessage != "sum")
                {
                    array[arraysNumber++] = Convert.ToInt32(userMessage);

                    for (int i = 0; i < array.Length; i++)
                    {
                        extendedArray[i] = array[i];                        
                    }

                    array = extendedArray;
                    Console.Clear();
                }

                else if (userMessage == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if(i< array.Length - 1)
                        {
                            Console.Write(array[i] + " ");
                        }
                        
                        arraySum += array[i];
                    }
                    Console.WriteLine();
                    Console.WriteLine("Сумма всех ячеек в массиве " + arraySum);
                }

                else if (userMessage == "exit")
                {
                    Console.WriteLine();
                    arraysWork = false;
                    Console.Write("Массив состоит из " + (array.Length - 1) + " ячеек, вами были введены числа: ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i < array.Length - 1)
                        {
                            Console.Write(array[i] + " ");
                        }
                        arraySum += array[i];
                    }

                    Console.WriteLine("Сумма всех чисел в массиве " + arraySum);
                }
            }

            Console.ReadKey();            
        }
    }
}
