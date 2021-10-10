using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_dossier
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jobWithDossier = true;
            List<string> dossierOfWorkers = new List<string>();
            int userInput;

            while (jobWithDossier)
            {
                Console.WriteLine("Работаем с досье, для добавления нового досье нажмите 1,\n" +
                    "чтобы вывести все досье введите 2, удалить досье 3, для выхода введите 4.");

                while(!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Неверный ввод, введите число в меню которого хотите перейти:");
                }

                switch (userInput)
                {
                    case (1):
                        AddNewDossier(dossierOfWorkers);
                        Console.Clear();
                        break;

                    case (2):
                        ShowAllDossier(dossierOfWorkers);
                        break;

                    case (3):
                        DeleteDossier(dossierOfWorkers);
                        Console.Clear();
                        break;

                    case (4):
                        jobWithDossier = false;
                        break;
                }
            }
        }

        static void AddNewDossier(List<string> dossierOfWorkers)
        {
            string surnameOfWorker;
            string nameOfWorker;
            string patronymicOfWorker;
            string positionOfWorker;
            string employeeData;

            Console.WriteLine("Введите поочерёдно, фамилию, имя, отчество, должность.");
            Console.Write("Фамилия:");
            surnameOfWorker = Console.ReadLine();
            Console.Write("Имя:");
            nameOfWorker = Console.ReadLine();
            Console.Write("Отчество:");
            patronymicOfWorker = Console.ReadLine();
            Console.Write("Должность:");
            positionOfWorker = Console.ReadLine();

            employeeData = surnameOfWorker + " " + nameOfWorker + " " + patronymicOfWorker + " - " + positionOfWorker;
            dossierOfWorkers.Add(employeeData);
            Console.WriteLine();
        }

        static void ShowAllDossier(List<string> dossierOfWorkers)
        {
            int numberPosition = 1;

            for (int i = 0; i < dossierOfWorkers.Count;i++)
            {
                Console.WriteLine(numberPosition++ + "." + dossierOfWorkers[i]);
            }

            Console.WriteLine();
        }

        static void DeleteDossier(List<string> dossierOfWorkers)
        {
            int numberPosition;
            int numberDossierForDelete;
            bool deleteDossier = true;

            while (deleteDossier)
            {
                Console.WriteLine("База досье:");

                for (numberPosition = 0; numberPosition < dossierOfWorkers.Count; numberPosition++)
                {
                    Console.WriteLine(numberPosition + 1 + "." + dossierOfWorkers[numberPosition]);
                }

                Console.Write("Введите номер досье которую хотите удалить:");

                while (!int.TryParse(Console.ReadLine(), out numberDossierForDelete))
                {
                    Console.WriteLine("Неверный ввод, введите номер досье для удаления:");
                }

                if (numberDossierForDelete > dossierOfWorkers.Count || numberDossierForDelete < 0)
                {
                    Console.WriteLine("Введён не верный номер досье");
                }

                else
                {
                    dossierOfWorkers.RemoveAt(numberDossierForDelete - 1);
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
