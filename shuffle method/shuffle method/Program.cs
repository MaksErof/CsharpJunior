using System;

namespace shuffle_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            FillTheArray(out array);
            ShuffleTheArray(array);
        }

        static void FillTheArray(out int[] array)
        {
            array = new int[10];
            Random rand = new Random();
                       
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 100);
                    Console.Write(array[i] + " ");
                }
        }

        static void ShuffleTheArray(int[] array)
        {
            Random rand = new Random();
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }

            Console.WriteLine();
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }

}
