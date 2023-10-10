using System;

namespace _004_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Hanoi(n, 'A', 'B', 'C');
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
        }
        private static void Hanoi(int n, char from, char to, char by)
        {
            if (n == 1)
            {
                Console.WriteLine("Move : {0} -> {1}", from, to);
            }
            else
            {
                Hanoi(n-1, from, by, to);
                Console.WriteLine("Move : {0} -> {1}", from, to);
                Hanoi(n - 1, by, to, from);
            }
        }
    }
}
