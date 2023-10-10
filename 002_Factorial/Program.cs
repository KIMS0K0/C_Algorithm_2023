using System;

namespace _002_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int x = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(rFactorial(x));
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(lFactorial(x));
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
        }
        //reculsive
        private static int rFactorial(int x)
        {
            if (x == 1) return 1;
            else return x * rFactorial(x-1);
        }
        //loop
        private static int lFactorial(int x)
        {
            int k = 1;
            for (int i = 2; i <= x; i++)
                k *= i;
            return k;
        }
    }
}
