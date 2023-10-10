using System;

namespace _003_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int x = int.Parse(Console.ReadLine());


            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(rFibonacci(x));
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);

            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(lFibonacci(x));
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
        }

        private static int rFibonacci(int x)
        {
            if (x == 1 | x == 2) return 1;
            else return rFibonacci(x - 1) + rFibonacci(x - 2);
        }

        private static int lFibonacci(int x)
        {
            int a = 0; int b = 0; int c = 1;
            for (int i = 1; i<x;i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }
    }
}
