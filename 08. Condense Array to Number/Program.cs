using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = arr.Length - 1;
            while (counter != 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    arr[i] = arr[i] + arr[i + 1];
                }
                counter--;
            }
            Console.WriteLine(arr[0]);

            //for (int i = arr.Length - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        arr[j] = arr[j] + arr[j + 1];
            //    }
            //}
            //Console.WriteLine(arr[0]);
        }
    }
}
