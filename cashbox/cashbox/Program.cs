using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Queue<int> shoppingInLine = new Queue<int>();
            int numberOfClients;
            int summOfClients;
                        
            AddClients(out numberOfClients, out summOfClients, rand, shoppingInLine);
            ServeTheClients(shoppingInLine, numberOfClients);
        }

        static void AddClients(out int numberOfClients, out int summOfClients ,Random rand, Queue<int> shoppingInLine)
        {
            summOfClients = rand.Next(15,500);
            numberOfClients = rand.Next(1,10);

            for (int i = 0; i < numberOfClients; i++)
            {
                shoppingInLine.Enqueue(summOfClients);
                summOfClients = rand.Next(500);
            }
        }

        static void ServeTheClients(Queue<int> shoppingInLine, int numberofClients)
        {
            int numberInTheQueue = 1;
            int cashboxShop = 0;

            for(int i = 0; i < shoppingInLine.Count;)
            {
                Console.SetCursorPosition(40,2);
                Console.WriteLine($"В очереди {numberofClients} клиентов");
                Console.SetCursorPosition(40, 3);
                Console.WriteLine($"Сумма {numberInTheQueue++} клиента {shoppingInLine.Peek()}");
                cashboxShop += shoppingInLine.Dequeue();
                Console.SetCursorPosition(40, 15);
                Console.Write($"Сумма на счёте:{cashboxShop}");
                Console.SetCursorPosition(40, 17);
                Console.WriteLine("Для продолжения нажмите любую клавишу:");
                Console.ReadKey();
                Console.Clear();
            }

            if (shoppingInLine.Count == 0)
            {
                Console.WriteLine($"Обслужено {numberofClients} клиентов");
            }

            Console.ReadKey();
        }
    }
}
