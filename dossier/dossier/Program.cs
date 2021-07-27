using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dossier
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool dossierFilling = true;
            string staffSurname;
            string staffName;
            string staffPatronymic;
            string staffPosition;
            string[,] staffData = new string[1,3];
            string[] employeePosition = new string[1];
            int staffForDelete;
            string surnameEmployee;
            string inputNumber;
            bool checkOnFool = false;
            string numberOfCommand;

            while (dossierFilling)
            {              
                Console.Write("Для заполнения досье введите - 1, Вывести все досье - 2, Удалить досье - 3, Поиск по фамилии - 4, Выход - 5: ");
                numberOfCommand = Console.ReadLine();

                if (numberOfCommand == "1" || numberOfCommand == "2" || numberOfCommand == "3" || numberOfCommand == "4" || numberOfCommand == "5")
                {
                    switch (numberOfCommand)
                    {
                        case "1":
                            Console.WriteLine();
                            Console.Write("Введите фамилию сотрудника: ");
                            staffSurname = Console.ReadLine();
                            Console.Write("Введите имя сотрудника: ");
                            staffName = Console.ReadLine();
                            Console.Write("Введите отчество сотрудника: ");
                            staffPatronymic = Console.ReadLine();
                            Console.Write("Введите должность сотрудника: ");
                            staffPosition = Console.ReadLine();

                            InputData(ref staffData, staffSurname, staffName, staffPatronymic);
                            InputPosition(ref employeePosition, staffPosition);

                            Console.WriteLine();
                            break;
                        case "2":
                            Console.Clear();

                            ShowData(staffData, employeePosition);
                            break;
                        case "3":

                            while (checkOnFool == false)
                            {
                                Console.Write("\nВведите номер досье для удаления: ");
                                inputNumber = Console.ReadLine();
                                checkOnFool = int.TryParse(inputNumber, out staffForDelete);

                                if (checkOnFool == true)
                                {
                                    DeleteDossier(ref staffData, ref employeePosition, staffForDelete);
                                }
                                else
                                    Console.WriteLine("Введено неверное значение");
                            }
                            break;
                        case "4":
                            Console.Write("\nКакого сотрудника вы хотите найти? Введите фамилию: ");
                            surnameEmployee = Console.ReadLine();

                            FindEmployee(staffData, employeePosition, surnameEmployee);
                            break;
                        case "5":
                            dossierFilling = false;
                            break;
                    }
                }
                else
                    Console.Clear();
                    Console.WriteLine("Введите правильную команду !");
            }
        }

       static void InputData (ref string[,] arraysOfStaff, string surName, string name, string patronimyc)
       {            
            string[,] increasingTheArrayOfStaff = new string[arraysOfStaff.GetLength(0) + 1, 3];            

            for(int i = 0; i < arraysOfStaff.GetLength(0); i++)
            {
                for(int j = 0; j < arraysOfStaff.GetLength(1); j++)
                {
                    arraysOfStaff[arraysOfStaff.GetLength(0) - 1, arraysOfStaff.GetLength(1) - 3] = surName;
                    arraysOfStaff[arraysOfStaff.GetLength(0) - 1, arraysOfStaff.GetLength(1) - 2] = name;
                    arraysOfStaff[arraysOfStaff.GetLength(0) - 1, arraysOfStaff.GetLength(1) - 1] = patronimyc;

                    increasingTheArrayOfStaff[i, j] = arraysOfStaff[i, j];
                }
            }

            arraysOfStaff = increasingTheArrayOfStaff;    
       }
        
        static void InputPosition(ref string[] arraysOfPosition, string staffPosition)
        {
            string[] increasingTheArrayOfPosition = new string[arraysOfPosition.Length + 1];

            for (int i = 0; i < arraysOfPosition.Length; i++)
            {
                if (i == arraysOfPosition.Length - 1)
                {
                    arraysOfPosition[i] = staffPosition;
                }
                increasingTheArrayOfPosition[i] = arraysOfPosition[i];
            }
            arraysOfPosition = increasingTheArrayOfPosition;
        }

        static void ShowData(string[,] staffData,  string[] staffPosition)
        {
            int numberPosition = 1;
            
            for (int i = 0; i < staffData.GetLength(0); i++)
            {
                if(staffData[i,0] != null)
                {
                    Console.Write(numberPosition++ + ". ");

                    for (int j = 0; j < staffData.GetLength(1); j++)
                    {
                        Console.Write(staffData[i, j] + " ");

                        if (j == staffData.GetLength(1) - 1)
                        {
                            Console.Write("- " + staffPosition[i]);
                        }
                    }

                    Console.WriteLine();
                }                
            }            
        }

        static void DeleteDossier(ref string[,] dataToDelete, ref string[] positionToDelete, int numberDossier)
        {
            numberDossier -= 1;
            string[,] newDataToStaff = new string[dataToDelete.GetLength(0) - 1, 3];
            string[] newPositionStaff = new string[positionToDelete.Length - 1];

            for (int i = 0; i < dataToDelete.GetLength(0); i++)
            {
               for(int j = 0; j < dataToDelete.GetLength(1); j++)
                {
                    if (i <= numberDossier)
                    {
                        newDataToStaff[i, j] = dataToDelete[i, j];
                        newPositionStaff[i] = positionToDelete[i];
                    }

                    if (i > numberDossier)
                    {
                        newDataToStaff[i - 1, j] = dataToDelete[i, j];
                        newPositionStaff[i - 1] = positionToDelete[i];
                    }                                        
                }
            }

            dataToDelete = newDataToStaff;
            positionToDelete = newPositionStaff;
        }

        static void FindEmployee(string[,] staffData, string[] staffPosition, string surnameEmployee)
        {            
            int numberPosition = 0;            

            for (int i = 0; i < staffData.GetLength(0) - 1; i++)
            {
                numberPosition++;

               for (int j = 0; j < staffData.GetLength(1); j++)
               {
                    if (surnameEmployee.ToLower() == staffData[i, j].ToLower())
                    {
                        Console.WriteLine(numberPosition + ". " + staffData[i, j] + " " + staffData[i,j + 1] + " "+ staffData[i,j + 2] + " - " + staffPosition[i]);
                    }                   
               }         
            }
        }
    }
}
