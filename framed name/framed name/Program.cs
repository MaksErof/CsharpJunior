using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framed_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string userSymbol = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i <= userName.Length; i++ )
            {                
                Console.SetCursorPosition(i,0);                
                Console.WriteLine(userSymbol);
                Console.SetCursorPosition(userName.Length + 1, 0);
                Console.WriteLine(userSymbol);
                Console.SetCursorPosition(0,1);
                Console.WriteLine(userSymbol);
                Console.SetCursorPosition(i,2);
                Console.WriteLine(userSymbol);
                Console.SetCursorPosition(userName.Length + 1, 2);
                Console.WriteLine(userSymbol);
                Console.SetCursorPosition(userName.Length +1 ,1);
                Console.WriteLine(userSymbol);
                Console.SetCursorPosition(1,1);
                Console.WriteLine(userName);                    
            }
            Console.ReadKey();
        }
    }
}
