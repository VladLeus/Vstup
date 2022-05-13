using System;

namespace Vstup
{
    class Program
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Введіть 1, щоб виконати 1 лабораторну роботу");
                Console.WriteLine("Введіть 2, щоб виконати 2 лабораторну роботу");
                Console.WriteLine("Введіть 3, щоб виконати 3 лабораторну роботу");
                Console.WriteLine("Введіть 0 щоб завершити роботу програми");
                Console.WriteLine("---------------------------------------------");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Lab1.DoLab1();
                        break;
                    case 2:
                        Lab2.DoLab2();
                        break;
                    case 3:
                        Lab3.DoLab3();
                        break;
                    case 0:
                        Console.WriteLine("Добре, завершую!");
                        break;
                    default:
                        Console.WriteLine("Такого значення для вибору немає, спробуйте ще раз.");
                        break;
                }
            } while (choice !=0);
        }
    }
}
