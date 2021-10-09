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
            int numberDossierForDelete;
            string surnameOfWorker;
            string nameOfWorker;
            string patronymicOfWorker;
            string positionOfWorker;

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
                        AddNewDossier(dossierOfWorkers,out surnameOfWorker,out nameOfWorker,out patronymicOfWorker,out positionOfWorker);
                        Console.Clear();
                        break;

                    case (2):
                        ShowAllDossier(dossierOfWorkers);
                        break;

                    case (3):
                        DeleteDossier(dossierOfWorkers,out numberDossierForDelete);
                        Console.Clear();
                        break;

                    case (4):
                        jobWithDossier = false;
                        break;
                }
            }
        }

        static void AddNewDossier(List<string> dossierOfWorkers, out string surnameOfWorker,out string nameOfWorker,out string patronymicOfWorker,out string positionOfWorker)
        {
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

        static void DeleteDossier(List<string> dossierOfWorkers, out int numberDossierForDelete)
        {
            bool deleteDossier = true;

            while (true)
            {
                Console.Write("Введите номер досье которую хотите удалить:");

                while (!int.TryParse(Console.ReadLine(), out numberDossierForDelete))
                {
                    Console.WriteLine("Неверный ввод, введите число в меню которого хотите перейти:");
                }

                if (numberDossierForDelete <= dossierOfWorkers.Count)
                {
                    dossierOfWorkers.RemoveAt(numberDossierForDelete - 1);
                    break;
                }

                else if (numberDossierForDelete > dossierOfWorkers.Count)
                {
                    Console.WriteLine("Введён не верный номер досье");
                }
            }

            Console.WriteLine();
        }
    }
}
