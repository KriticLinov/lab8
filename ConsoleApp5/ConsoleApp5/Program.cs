using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static float Power(int number, int level)
        {
            float p = 1;

            for (int i = 1; i <= level; i++)
            {
                p *= number;
            }

            return p;
        }
        static void Power(int number, int level, out float result)
        {
            result = 1;
            for (int i = 1; i <= level; i++)
            {
                result *= number;
            }
        }

        static float Factorial(int maxNumber)
        {
            float p = 1;

            for (int i = 1; i <= maxNumber; i++)
            {
                p *= i;
            }

            return p;
        }

        static void Factorial(int maxNumber, out float result)
        {
            result = 1;

            for (int i = 1; i <= maxNumber; i++)
            {
                result *= i;
            }
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            float f = x + Power(a, n) + Factorial(y) / Power(a, m);

            //Power(a, n, out float p1);
            //Power(a, m, out float p2);
            //Factorial(y, out float p3);

            //float f = x + p1 + p3 / p2;

            Console.WriteLine($"{f:f2}");
        }
    }
}
