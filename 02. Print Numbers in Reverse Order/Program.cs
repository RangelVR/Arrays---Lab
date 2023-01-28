using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
--------------------------------------------------------------
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(arr);
            //Console.WriteLine(string.Join(" ", arr));

--------------------------------------------------------------
            //for (int i = 0; i < n; i++)
            //{
            //    int currNum = int.Parse(Console.ReadLine());
            //    arr[i] = currNum;
            //}
            //for (int i = arr.Length - 1; i >=0 ; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            
            //int n = int.Parse(Console.ReadLine());
--------------------------------------------------------------
            //int[] arr = new int[n];
            //int counter = n - 1;

            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    arr[counter] = number;
            //    counter--;
            //}

            //Console.WriteLine(string.Join(" ", arr));

        }
    }
}
