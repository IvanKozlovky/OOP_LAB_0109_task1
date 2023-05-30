using System;

namespace TrapezoidalIntegration
{
    public delegate double Function(double x);

    public class TrapezoidalIntegration
    {
        public static double CalculateIntegral(Function function, double a, double b, int n)
        {
            double h = (b - a) / n;
            double result = 0;

            for (int i = 0; i <= n; i++)
            {
                double x = a + i * h;
                double y = function(x);

                if (i == 0 || i == n)
                {
                    result += y;
                }
                else
                {
                    result += 2 * y;
                }
            }

            result *= h / 2;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Function function = x => Math.Sin(x); // Наприклад, функція sin(x)
            double a = 0;
            double b = Math.PI;
            int n = 1000;

            double result = TrapezoidalIntegration.CalculateIntegral(function, a, b, n);
            Console.WriteLine($"Результат обчислення визначеного інтеграла: {result}");
        }
    }
}
