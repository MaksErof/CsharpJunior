using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [3,3];
            Random anyNumber = new Random();
            int productOfNumbers = 1;
            int sum = 0;

            Console.WriteLine("Исходная матрица\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = anyNumber.Next(0,9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();                
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                oneTask *= array[i, 0];
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[1, i];
            }

            Console.SetCursorPosition(0,6);
            Console.WriteLine("Произведение первого столбца " + oneTask);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Сумма второй строки " + sum);
            Console.ReadKey();
        }
    }
}
