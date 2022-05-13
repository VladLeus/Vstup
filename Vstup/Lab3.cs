using System;

namespace Vstup
{
    class Lab3
    {
        public static void DoLab3()
        {
            Console.WriteLine("Введіть перше число у двійковій системі числення:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введіть друге число у двійковій системі числення:");
            string num2 = Console.ReadLine();
            int x = Convert.ToInt32(num1, 2);
            int y = Convert.ToInt32(num2, 2);
            int result = x * y;
            Console.WriteLine("\nDecimal: {0}", result + "\nBinary: " + Convert.ToString(result, 2).PadLeft(8,'0'));
            Console.WriteLine("Натисніть Еnter, щоб перейти до вибору лабораторних робіт");
            Console.ReadKey();
        }
    }
}
