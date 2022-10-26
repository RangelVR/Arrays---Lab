using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                if (n % 2 == 0)
                {
                    sumEven += n;
                }
                else if (n % 2 != 0)
                {
                    sumOdd += n;
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
