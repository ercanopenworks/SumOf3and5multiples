using System;

namespace _3and5multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine()) - 1;

                long sumOfN = sumOfMultiples(3, n / 3) + sumOfMultiples(5, n / 5) - sumOfMultiples(15, n / 15);
                Console.WriteLine(sumOfN);
            }
        }

        static long sumOfMultiples(long n, long p)
        {
            //p * (p + 1) / 2 = summary of (number of items)

            return n * (p * (p + 1) / 2);


        }
    }
}
