using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace score
{
    class Program
    {
        static void Main(string[] args)
        {
            int cristalsPrice = 25;
            Console.WriteLine("Введите количество у вас золота :");
            int goldInPocket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько хотите приобрести кристаллов:");
            int buiyngCristals = Convert.ToInt32(Console.ReadLine());
            int priceForBuyingCristals = cristalsPrice * buiyngCristals;
            int restOfMoney = goldInPocket - buiyngCristals * cristalsPrice;
            Console.WriteLine($"Вы можете купить {buiyngCristals} кристаллов" + 
                $" у вас останется {restOfMoney} золота");
            Console.ReadKey();

                
        }
    }
}
