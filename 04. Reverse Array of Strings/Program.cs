using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Array.Reverse(input);
            Console.WriteLine(string.Join(" ", input));

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{input[i]} ");
            //}
        }
    }
}
