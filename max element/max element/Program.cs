using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfColumns = 10;
            int numbersOfLines = 10;
            int[,] array = new int[numberOfColumns,numbersOfLines];
            Random rand = new Random();
            int maxElement = int.MinValue;                       

            Console.WriteLine("Начальная матрица\n");

            for (numberOfColumns = 0;  numberOfColumns < array.GetLength(0); numberOfColumns++)
            {                
                for (numbersOfLines = 0; numbersOfLines < array.GetLength(1); numbersOfLines++)
                {
                    array[numberOfColumns, numbersOfLines] = rand.Next(0, 20);
                    Console.Write(array[numberOfColumns, numbersOfLines] + " ");                    
                }

                Console.WriteLine();                
            }

            Console.SetCursorPosition(0,13);

            for(numberOfColumns = 0; numberOfColumns < array.GetLength(0); numberOfColumns++)
            {
                for (numbersOfLines = 0; numbersOfLines < array.GetLength(1); numbersOfLines++)
                {
                    if(maxElement < array[numberOfColumns, numbersOfLines])
                    {
                        maxElement = array[numberOfColumns, numbersOfLines];
                    }
                }                
            }
            Console.Write("Максимальный элемент в матрице равен:");
            Console.WriteLine(maxElement);
            Console.WriteLine();

            Console.WriteLine("Изменённая матрица\n");            

            for (numberOfColumns = 0; numberOfColumns < array.GetLength(0); numberOfColumns++)
            {                
                for (numbersOfLines = 0; numbersOfLines < array.GetLength(1); numbersOfLines++)
                {                    
                    if (maxElement == array[numberOfColumns, numbersOfLines])
                    {
                        array[numberOfColumns, numbersOfLines] = 0;
                    }

                    Console.Write(array[numberOfColumns,numbersOfLines] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
