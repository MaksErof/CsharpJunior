using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summ_all_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool enterNumbers = true;
            string userInput;
            List<int> listOfNumbers = new List<int>();

            while (enterNumbers)
            {
                Console.WriteLine("Для добавления вводите числа, для сложения введите sum, для выхода введите exit");

                switch (userInput = Console.ReadLine())
                {
                    default:
                       int userNumber;
                       while(int.TryParse(userInput, out userNumber))
                       {
                            AddNumbers(listOfNumbers, userNumber);
                            break;
                       }
                        Console.Clear();
                        break;

                    case ("sum"):
                        SumAllNumbers(listOfNumbers);
                        break;

                    case ("exit"):
                        enterNumbers = false;
                        break;
                }
            }
        }

        static void AddNumbers(List<int> listOfNumbers, int userInput)
        {
            listOfNumbers.Add(userInput);
        }

        static void SumAllNumbers(List<int> listOfNumbers)
        {
            int sumOfListNumbers = 0;
            for (int i = 0; i<listOfNumbers.Count;i++)
            {
                sumOfListNumbers += listOfNumbers[i];
            }

            Console.WriteLine($"Сумма всех чисел в списке {sumOfListNumbers}");
        }
    }
}
