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
            bool endFilling = true;          
            string staffSurname;           
            string staffPosition;
            string[] staffData = new string[1];
            string[] employeePosition = new string[1];
            int staffForDelete;
            string surnameEmployee;

            while (endFilling)
            {                
                Console.Write("Для заполнения досье введите - 1, Вывести все досье - 2, Удалить досье - 3, Поиск по фамилии - 4, Выход - 5: ");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Введите фамилию, имя и отчество сотрудника: ");
                        staffSurname = Console.ReadLine();                        
                        Console.Write("Введите должность сотрудника: ");
                        staffPosition = Console.ReadLine();

                        staffData = dataInput(staffData,ref employeePosition, staffSurname, staffPosition);

                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine();

                        showData(staffData, employeePosition);
                        break;
                    case "3":
                        Console.Write("\nВведите номер досье для удаления: ");
                        staffForDelete = Convert.ToInt32(Console.ReadLine());

                        staffData = dossierDeletion(staffData, ref employeePosition, staffForDelete);

                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("\nКакого сотрудника вы хотите найти? Введите фамилию, имя и отчество: ");
                        surnameEmployee = Console.ReadLine();
                        findEmployee(ref staffData, surnameEmployee);
                        break;
                    case "5":
                        endFilling = false;
                        Console.WriteLine("Выход из редактора");
                        break;
                }     
            }
        }

       static string[] dataInput (string[] arraysOfStaff,ref string[] arraysOfPosition, string staffName, string staffPosition)
       {            
            string[] increasingTheArrayOfStaff = new string[arraysOfStaff.Length + 1];
            string[] increasingTheArrayOfPosition = new string[arraysOfPosition.Length + 1];

           for (int i = 0; i < arraysOfStaff.Length; i++)
            {               
                if(arraysOfStaff[i] == null)
                {
                    arraysOfStaff[i] = staffName;
                }                
                increasingTheArrayOfStaff[i] = arraysOfStaff[i];
            }
            arraysOfStaff = increasingTheArrayOfStaff;

            for(int i = 0; i < arraysOfPosition.Length; i++)
            {
                if (arraysOfPosition[i] == null)
                {
                    arraysOfPosition[i] = staffPosition;
                }
                increasingTheArrayOfPosition[i] = arraysOfPosition[i];
            }
            arraysOfPosition = increasingTheArrayOfPosition;

          return arraysOfStaff;
       }

        static void showData(string[] staffData,  string[] staffPosition)
        {
            int numberPosition = 1;
            
            for (int i = 0; i < staffData.Length; i++)
            {
                if(i != staffPosition.Length - 1)
                {
                    Console.WriteLine(numberPosition++ +". " + staffData[i] + " - " + staffPosition[i]);
                }                
            }
            
        }

        static string[] dossierDeletion (string[] dataToDelete, ref string[] positionToDelete, int numberDossier)
        {
            numberDossier -= 1;
            string[] newDataToStaff = new string[dataToDelete.Length - 1] ;
            string[] newPositionStaff = new string[positionToDelete.Length - 1];

            for(int i = 0; i < numberDossier; i++)
            {
                newDataToStaff[i] = dataToDelete[i];
                newPositionStaff[i] = positionToDelete[i];
            }

            for(int i = numberDossier + 1;i < dataToDelete.Length; i ++)
            {
                newDataToStaff[i - 1] = dataToDelete[i];
                newPositionStaff[i - 1] = positionToDelete[i];
            }

            dataToDelete = newDataToStaff;
            positionToDelete = newPositionStaff;

            return dataToDelete;
        }

        static void findEmployee(ref string[] array, string numberEmployee)
        {
            for(int i = 0;i< array.Length; i++)
            {
                if(numberEmployee == array[i])
                {
                    Console.WriteLine("Вы искали этого сотрудника " + array[i]);
                }
            }
        }

    }
}
