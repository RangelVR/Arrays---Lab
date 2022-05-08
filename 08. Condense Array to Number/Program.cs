using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = arr.Length - 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    arr[j] = arr[j] + arr[j + 1];
                }
                counter--;
                
            }

            Console.WriteLine(arr[0]);
        }
    }
}
