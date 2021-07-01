using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximums
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int [30];
            Random anyNumber = new Random();            
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = anyNumber.Next(0,31);

                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length-1)
                {
                    if (i < 1)
                    {
                        if (array[0] > array[1])
                        {
                            Console.WriteLine("локальный максимум " + array[i]);
                        }
                    }                                      

                   if (i >= 1 && i <= array.Length)
                   {
                       if (array[i] > array[i - 1] && array[i] > array[i + 1])
                       {
                          Console.WriteLine("Локальный максимум " + array[i]);
                       }
                   }

                   if(i == array.Length - 2)
                   {
                       if (array[array.Length-1] > array[array.Length - 2])
                       {
                            Console.WriteLine("Конец массива, локальный максимум " + array[array.Length -1 ]);
                       }
                   }
                }                
            }

            Console.ReadKey();
        }
    }
}
