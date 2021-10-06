using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> wordsAndValue = new Dictionary<string, string>();
            string userInput;

            Console.WriteLine("На текущий момент в словаре вы можете посмотреть значения следующих слов:");
            Console.WriteLine("Значение какого слова вы хотите узнать?");
            ShowAllWord(wordsAndValue);
            userInput = Console.ReadLine();
            Console.Clear();
            ShowValueWord(userInput, wordsAndValue);
        }

        static void ShowValueWord(string userInput, Dictionary <string, string> wordsAndValue)
        {
            string keysOfDictionary = "";   

            foreach (var item in wordsAndValue)
            {
                keysOfDictionary = item.Key;

                if(userInput.ToLower() == keysOfDictionary.ToLower())
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                    break;
                }
            }
            
            if(userInput.ToLower() != keysOfDictionary.ToLower())
            {
                Console.WriteLine("Введённое слово и его значение не записано в словарь, либо слово введено не правильно");
            }
        }

        static void ShowAllWord(Dictionary<string, string> wordsAndValue)
        {
            int numberWord = 1;

            wordsAndValue.Add("Модернизация", "Обновление объекта, приведение его в соответствие с новыми требованиями и нормами, техническими условиями, показателями качества.");
            wordsAndValue.Add("Напутствие", "Слова, пожелания отправляющемуся в путь");
            wordsAndValue.Add("Курьёз", "Странный, диковинный или смешной случай.");

            foreach (var item in wordsAndValue)
            {
                Console.WriteLine(numberWord++ + "." + item.Key);
            }
        }
    }
}
