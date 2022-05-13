using System;

namespace Vstup
{
    class Lab2
    {
        static double BinaryToDecimal(string binary, int len)
        {
            int point = binary.IndexOf('.');

            if (point == -1)
            {
                point = len;
            }
            
            double intDecimal = 0,
                fracDecimal = 0,
                twos = 1;

            for (int i = point - 1; i >= 0; i--)
            {
                intDecimal += (binary[i] - '0') * twos;
                twos *= 2;
            }

            twos = 2;
            for (int i = point + 1; i < len; i++)
            {
                fracDecimal += (binary[i] - '0') / twos;
                twos *= 2.0;
            }

            return intDecimal + fracDecimal;
        }
        public static void DoLab2()
        {
            Console.Clear();
            Console.WriteLine("Введіть число в двійковій системі числення");
            string num = Console.ReadLine();
            double result = BinaryToDecimal(num, num.Length);
            Console.WriteLine(Math.Round(result, 8));
            Console.WriteLine("Натисніть Еnter, щоб перейти до вибору лабораторних робіт");
            Console.ReadKey();
        }
    }
}
