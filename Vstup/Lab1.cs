using System;

namespace Vstup
{
    class Lab1
    {
        public static void DoLab1()
        {
            Console.Clear();
            Console.WriteLine("Введіть число в двійковій системі числення");
            string num = Console.ReadLine();
            int toFormat = 16;
            int fromFormat = 2;
            string result = Convert.ToString(Convert.ToInt32(num, fromFormat), toFormat);
            Console.WriteLine($"Ваше число в 16-річній системі числення: {result}");
            Console.WriteLine("Натисніть Еnter, щоб перейти до вибору лабораторних робіт");
            Console.ReadKey();
        }
    }
}
