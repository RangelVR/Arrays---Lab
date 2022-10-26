using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            
            
            //bool isEqual = arr1.SequenceEqual(arr2);
            ////  bool isEqual = Enumerable.SequenceEqual(arr1, arr2);
            //if (isEqual)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {arr1.Sum()}");
            //}
            //else
            //{
            //    int difIndex = 0;
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        if (arr1[i] != arr2[i])
            //        {
            //            difIndex = i;
            //            Console.WriteLine($"Arrays are not identical. Found difference at {difIndex} index");
            //            break;
            //        }
            //    }
            //}
        }
    }
}
