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
            string[] staffData = new string[2];
            string[] employeePosition = new string[2];
            int staffForDelete;
            string surnameEmployee;

            while (dossierFilling)
            {              
                Console.Write("Для заполнения досье введите - 1, Вывести все досье - 2, Удалить досье - 3, Поиск по фамилии - 4, Выход - 5: ");
                
                switch (Console.ReadLine())
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
                        Console.Write("\nВведите номер досье для удаления: ");
                        staffForDelete = Convert.ToInt32(Console.ReadLine());

                        DeleteDossier(ref staffData, ref employeePosition, staffForDelete);

                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("\nКакого сотрудника вы хотите найти? Введите фамилию: ");
                        surnameEmployee = Console.ReadLine();
                        FindEmployee(staffData, employeePosition, surnameEmployee);
                        break;
                    case "5":
                        dossierFilling = false;
                        Console.WriteLine("Выход из редактора");
                        break;
                }     
            }
        }

       static void InputData (ref string[] arraysOfStaff, string surName, string name, string patronimyc)
       {            
            string[] increasingTheArrayOfStaff = new string[arraysOfStaff.Length + 2];            

           for (int i = 0; i < arraysOfStaff.Length; i++)
            {               
                if(arraysOfStaff[i] == null)
                {
                    arraysOfStaff[i] = surName;
                    arraysOfStaff[i + 1] = " " + name + " " + patronimyc;
                }                
                increasingTheArrayOfStaff[i] = arraysOfStaff[i];
            }
            arraysOfStaff = increasingTheArrayOfStaff;         
       }
        
        static void InputPosition(ref string[] arraysOfPosition, string staffPosition)
        {
            string[] increasingTheArrayOfPosition = new string[arraysOfPosition.Length + 2];

            for (int i = 0; i < arraysOfPosition.Length; i++)
            {
                if (arraysOfPosition[i] == null && i % 2 == 0)
                {
                    arraysOfPosition[i] = staffPosition;
                }
                increasingTheArrayOfPosition[i] = arraysOfPosition[i];
            }
            arraysOfPosition = increasingTheArrayOfPosition;
        }

        static void ShowData(string[] staffData,  string[] staffPosition)
        {
            int numberPosition = 1;
            
            for (int i = 0; i < staffData.Length; i++)
            {                
                if(i != staffData.Length - 2 && i % 2 == 0)
                {
                    Console.WriteLine(numberPosition++ + ". " + staffData[i] + staffData[i+1] + " - " + staffPosition[i]);
                }          
            }
            
        }

        static void DeleteDossier (ref string[] dataToDelete, ref string[] positionToDelete, int numberDossier)
        {
            int numberPosition = 1;
            int emptyValue = 1;
            string[] newDataToStaff = new string[dataToDelete.Length - 2] ;
            string[] newPositionStaff = new string[positionToDelete.Length - 2];

            for (int i = 0; i < dataToDelete.Length; i++)
            {               
                if(i % 2 == 0)
                {
                    if (numberDossier == numberPosition && i % 2 == 0)
                    {                        
                        dataToDelete[i] = null; dataToDelete[i + 1] = null; positionToDelete[i] = null;
                    }

                    numberPosition++;
                }
                
            }

            for(int i = 0; i < newDataToStaff.Length - 2; i++)
            {
                newDataToStaff[i] = dataToDelete[i];
                newPositionStaff[i] = positionToDelete[i];

                if (emptyValue <= 2 && dataToDelete[i] == null)
                {                  
                        newDataToStaff[i] = dataToDelete[i + 2];
                        newPositionStaff[i] = positionToDelete[i + 2];
                        emptyValue++;                    
                }
            }

            dataToDelete = newDataToStaff;
            positionToDelete = newPositionStaff;            
        }

        static void FindEmployee(string[] staffData, string[] staffPosition, string surnameEmployee)
        {
            int numberPosition = 1;
            for(int i = 0;i< staffData.Length; i++)
            {
                if(surnameEmployee == staffData[i] && i % 2 == 0)
                {
                    Console.Write("Вы искали этого сотрудника: " + numberPosition++ + ". " + staffData[i] + staffData[i + 1] + " - " + staffPosition[i] + "\n");
                }               
            }
        }

    }
}
