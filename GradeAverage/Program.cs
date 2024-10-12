using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using GradeAverage.Input;

namespace GradeAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] Grades = new double[3, 2];
            string[] Names = new string[3];
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Enter First Student's Name :");
                        break;
                    case 1:
                        Console.WriteLine("Enter Second Student's Name :");
                        break;
                    case 2:
                        Console.WriteLine("Enter Third Student's Name :");
                        break;
                }
                Names[i] = Console.ReadLine();
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter Grade{0} :", j + 1);
                    double? Test = DoubleInput.Get();
                    if (Test == null)
                        break;
                    Grades[i, j] = (int)Test;
                }
            }
            bool Exit = true;
            while (Exit)
            {
                Console.WriteLine(" \nEnter \"1\" to Edit Grades");
                Console.WriteLine("Enter \"2\" to Edit Names");
                Console.WriteLine("Enter \"3\" to Calculate Grade Average");
                Console.WriteLine("Enter \"0\" to Exit");
                double? Menu = DoubleInput.Get();
                switch (Menu)
                {
                    case 0:
                        Console.WriteLine("Thanks For Checking This Out !!");
                        Exit = false;
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine("Enter Student Number :");
                        double? SNum = DoubleInput.Get();
                        Console.WriteLine("Enter Grade Number :");
                        double? GNum = DoubleInput.Get();
                        if (GNum != null && SNum != null)
                        {
                            Console.WriteLine("Enter New Grade :");
                            double? NewGrade = DoubleInput.Get();
                            if (NewGrade == null)
                            {
                                Console.WriteLine("Grade Has not Been Updated");
                                Console.ReadKey();
                                break;
                            }
                            Grades[(int)SNum - 1, (int)GNum - 1] = (int)NewGrade;
                        }
                        Console.WriteLine("Grade Has Been Updated");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Enter Student Number :");
                        double? Num = DoubleInput.Get();
                        if (Num == null)
                        {
                            Console.WriteLine("Name Did Not Updated !!");
                            break;
                        }
                        Console.WriteLine("Enter New Name : ");
                        Names[(int)Num - 1] = Console.ReadLine();
                        Console.WriteLine("Name Has Been Updated");
                        Console.ReadKey();
                        break;
                    case 3:
                        for (int i = 0;i < 3; i++)
                        {
                            Console.WriteLine(" \n\"Student {0}\"", i + 1);
                            Console.WriteLine($"Name : {Names[i]}");
                            for (int j = 0; j < 2; j++)
                            {
                                Console.WriteLine($"Grade {j+1} : {Grades[i,j]}");
                            }
                            Console.WriteLine("Average : {0}", (Grades[i, 0] + Grades[i, 1]) / 2);
                        }
                        Console.ReadKey();
                        break;
                }
                    
            }
        }
    }
}
