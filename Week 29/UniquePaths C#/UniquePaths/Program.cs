using System;

namespace UniquePaths
{
    class Program
    {

        static int UniquePathCount(int m, int n)
        {
            if(m == 1 || n == 1)
            {
                return 1;
            } else
            {
                int upc = UniquePathCount(m - 1, n) + UniquePathCount(m, n - 1);
                return upc;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter M:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            int upc = UniquePathCount(m, n);

            Console.WriteLine("Number of Unique Paths : " + upc.ToString());
        }
    }
}
