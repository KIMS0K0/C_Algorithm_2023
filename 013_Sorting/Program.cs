using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Sorting
{
    internal class Program
    {
        static int N = 100;
        static int[] a = new int[N];
        static Random r = new Random();

        static void Main(string[] args)
        {
            RandomInit();
            PrintArray();

            Console.WriteLine(":: Array.Sort()");

            Array.Sort(a);
            PrintArray();

            Console.WriteLine(":: BubbleSort");

            RandomInit();
            BubbleSort();

            Console.WriteLine(":: SelectionSort");

            RandomInit();
            SelectionSort();
            
            Console.WriteLine(":: InsertionSort");

            RandomInit();
            InsertionSort();
        }
        private static void PrintArray()
        {
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine('\n');
        }
        private static void RandomInit()
        {
            //Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = r.Next(1000);
            }
        }
        private static void Swap(int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
        private static void BubbleSort()
        {
            for(int i = N-1;i>=0;i--)
                for(int j = 0; j < i; j++)
                    if (a[j] > a[j + 1])
                        Swap(j, j + 1);
            PrintArray();
        }
        private static void SelectionSort()
        {
            for(int i = 0; i < N - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                    if (a[min] < a[j])
                        min = j;
                Swap(i, min);
            }
            PrintArray();
        }
        private static void InsertionSort()
        {
            throw new NotImplementedException();
        }
    }
}
