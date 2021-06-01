using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyUserRub = 300000;
            float moneyUserUsd = 250f;
            float moneyUserEur = 190f;

            float euroToRubPrice = 89f;
            float usdToRubPrice = 73f;
            float usdToEurPrice = 0.82f;            

            Console.WriteLine("На вашем счёте 300000 рублей, 250 долларов и 190 евро, для конвертации введите enter, для выхода exit");
            string transfer = Console.ReadLine();

            while (transfer != "exit")
            {
                Console.WriteLine("Конвертёр валют, для выхода введите exit.");
                Console.WriteLine("Какую валюту вы хотели бы конвертировать ?");
                Console.WriteLine("Если хотите обменять рубли на доллары введите 1");
                Console.WriteLine("Для обмена рублей на евро введите 2");
                Console.WriteLine("для обмена долларов на евро введите 3");
                Console.WriteLine("Для обмена евро на доллары введите 4");
                Console.WriteLine("Для хотите обменять доллары на рубли введите 5");
                Console.WriteLine("Для обмена евро на рубли введите 6");
                

                transfer = Console.ReadLine();
                switch (transfer)
                {
                    case "1":
                        Console.WriteLine("Сколько рублей вы желаете обменять на доллары?");
                        float amountOfTransfer = Convert.ToSingle(Console.ReadLine());

                        if (moneyUserRub > amountOfTransfer)
                        {
                            moneyUserUsd += amountOfTransfer / usdToRubPrice;
                            moneyUserRub -= amountOfTransfer;

                            Console.Clear();
                            Console.WriteLine($"Вы обменяли {amountOfTransfer} рублей на {Math.Round(amountOfTransfer / usdToRubPrice, 2)} долларов");                            
                            Console.WriteLine($"Теперь у вас {moneyUserRub} рублей, {Math.Round(moneyUserUsd, 2)} долларов и {Math.Round(moneyUserEur, 2)} евро.");
                            Console.WriteLine();                            
                        }

                        else
                            Console.WriteLine("Недостаточное количество денег");
                            Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Сколько рублей вы желаете обменять на евро?");

                        amountOfTransfer = Convert.ToSingle(Console.ReadLine());

                        if (moneyUserRub > amountOfTransfer)
                        {
                            moneyUserEur += amountOfTransfer / euroToRubPrice;
                            moneyUserRub -= amountOfTransfer;

                            Console.Clear();
                            Console.WriteLine($"Вы обменяли {amountOfTransfer} рублей на {Math.Round(amountOfTransfer / euroToRubPrice, 2)} евро");                            
                            Console.WriteLine($"Теперь у вас {moneyUserRub} рублей, {Math.Round(moneyUserUsd, 2)} долларов и {Math.Round(moneyUserEur, 2)} евро.");
                            Console.WriteLine();
                        }

                        else
                            Console.WriteLine("Недостаточное количество денег");                        
                        break;

                    case "3":
                        Console.WriteLine("Сколько долларов вы желаете обменять на евро?");
                        amountOfTransfer = Convert.ToSingle(Console.ReadLine());

                        if (moneyUserUsd>amountOfTransfer)
                        {
                            moneyUserEur += amountOfTransfer * usdToEurPrice;
                            moneyUserUsd -= amountOfTransfer;

                            Console.Clear();
                            Console.WriteLine($"Вы обменяли {amountOfTransfer} долларов на {Math.Round(amountOfTransfer / usdToEurPrice, 2)} евро");                            
                            Console.WriteLine($"Теперь у вас {moneyUserRub} рублей, {Math.Round(moneyUserUsd, 2)} долларов и {Math.Round(moneyUserEur, 2)} евро.");
                            Console.WriteLine();
                        }

                        else
                            Console.WriteLine("Недостаточное количество денег");
                        break;

                    case "4":
                        Console.WriteLine("Сколько евро вы желаете обменять на доллары?");
                        amountOfTransfer = Convert.ToSingle(Console.ReadLine());

                        if (moneyUserEur > amountOfTransfer)
                        {
                            moneyUserUsd += amountOfTransfer / usdToEurPrice;
                            moneyUserEur -= amountOfTransfer;

                            Console.Clear();
                            Console.WriteLine($"Вы обменяли {amountOfTransfer} долларов на {Math.Round(amountOfTransfer / usdToEurPrice, 2)} евро");                            
                            Console.WriteLine($"Теперь у вас {moneyUserRub} рублей, {Math.Round(moneyUserUsd, 2)} долларов и {Math.Round(moneyUserEur, 2)} евро.");
                            Console.WriteLine();
                        }

                        else
                            Console.WriteLine("Недостаточное количество денег");
                        break;

                    case "5":
                        Console.WriteLine("Сколько долларов вы желаете обменять на рубли?");
                        amountOfTransfer = Convert.ToSingle(Console.ReadLine());

                        if (moneyUserUsd>amountOfTransfer)
                        {
                            moneyUserRub += amountOfTransfer * usdToRubPrice;
                            moneyUserUsd -= amountOfTransfer;

                            Console.Clear();
                            Console.WriteLine($"Вы обменяли {amountOfTransfer} долларов на {Math.Round(amountOfTransfer * usdToRubPrice, 4)} рублей");                            
                            Console.WriteLine($"Теперь у вас {moneyUserRub} рублей, {Math.Round(moneyUserUsd, 2)} долларов и {Math.Round(moneyUserEur, 2)} евро.");
                            Console.WriteLine();
                        }

                        else
                            Console.WriteLine("Недостаточное количество денег");

                        break;

                    case "6":
                        Console.WriteLine("Сколько евро вы желаете обменять на рубли?");
                        amountOfTransfer = Convert.ToSingle(Console.ReadLine());

                        if (moneyUserEur>amountOfTransfer)
                        {
                            moneyUserRub += amountOfTransfer * euroToRubPrice;
                            moneyUserEur -= amountOfTransfer;

                            Console.Clear();
                            Console.WriteLine($"Вы обменяли {amountOfTransfer} евро на {Math.Round(amountOfTransfer * euroToRubPrice, 4)} рублей");                            
                            Console.WriteLine($"Теперь у вас {moneyUserRub} рублей, {moneyUserUsd} долларов и {Math.Round(moneyUserEur, 2)} евро.");
                            Console.WriteLine();
                        }

                        else
                            Console.WriteLine("Недостаточное количество денег");
                        break;
                }          
            }           
            Console.WriteLine($"На данный момент у вас {moneyUserRub} рублей {Math.Round(moneyUserUsd, 2)} долларов и {Math.Round(moneyUserEur, 2)} евро");
            Console.ReadKey();
        }
    }
}
