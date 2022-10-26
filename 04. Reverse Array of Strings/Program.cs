using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
