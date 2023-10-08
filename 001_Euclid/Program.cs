using System;
using System.Diagnostics;

namespace _001_Euclid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            var elapsedTicks = watch.ElapsedTicks;

            Console.Write("N1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("N2: ");
            int y = int.Parse(Console.ReadLine());


            watch = Stopwatch.StartNew();
            int rGCD = rEuclid(x, y);
            watch.Stop();
            Console.WriteLine("\nreculsive : " + rGCD);
            WriteTimer(rGCD, watch);


            watch = Stopwatch.StartNew();
            int lGCD = lEuclid(x, y);
            watch.Stop();
            Console.WriteLine("\nloop : " + lGCD);
            WriteTimer(lGCD, watch);
        }

        //reculsive
        private static int rEuclid(int x, int y)
        {
            if (y == 0) return x;
            else return rEuclid(y, x % y);
        }
        //loop
        private static int lEuclid(int x, int y)
        {
            while (y != 0)
            {
                int t = y;
                y = x % y;
                x = t;
            }
            return x;
        }
        //Timer
        private static void WriteTimer(int k, Stopwatch watch)
        {
            long elapsedTicks = watch.ElapsedTicks;
            Console.WriteLine("Ticks : " + elapsedTicks);
            Console.WriteLine("ms : " + elapsedTicks/10000.0);
        }
    }
}