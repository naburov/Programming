using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3();
        }

        private static void Task3()
        {
            double a = 100;
            double b = 0.001;

            double dividend = CalculateDividend(a, b);
            double divider = CalculateDivider(a, b);
            double result = dividend / divider;

            Console.WriteLine(result);
        }

        private static double CalculateDivider(double a, double b)
        {
            return Math.Pow(b, 3) + 3 * a * b * b + 3 * a * a * b;
        }

        private static double CalculateDividend(double a, double b)
        {
            return Math.Pow(a + b, 3) - Math.Pow(a, 3);
        }

        private static void Task2()
        {
            double x = InputX();
            double y = InputY();
            bool result = IsBelong(x, y);

            if (result)
                Console.WriteLine("Точка принадлежит заштрихованной области");
            else
                Console.WriteLine("Точка не принадлежит заданной области");
        }

        private static bool IsBelong(double x, double y)
        {
            if (x > 0)
                return (y < -x + 2) && (y > x - 2);             
            else
                return (x * x + y * y <= 4);
        }

        private static double InputY()
        {
            Console.WriteLine("Введите Y:");
            string input = Console.ReadLine();
            double y = Convert.ToDouble(input);
            return y;
        }

        private static double InputX()
        {
            Console.WriteLine("Введите X:");
            string input = Console.ReadLine();
            double x = Convert.ToDouble(input);
            return x;
        }
    }
}
