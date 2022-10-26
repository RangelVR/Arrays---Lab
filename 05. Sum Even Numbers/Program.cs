using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
