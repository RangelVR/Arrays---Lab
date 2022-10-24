using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (n > 0 && n < 8)
            {
                Console.WriteLine(weekDays[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            
            //int n = int.Parse(Console.ReadLine());
            //string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //
            //for (int i = 0; i < weekDays.Length; i++)
            //{
            //    if (n > 0 && n < 8)
            //    {
            //        if (i == n - 1)
            //        {
            //            Console.WriteLine(weekDays[i]);
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid day!");
            //        break;
            //    }
            //}

        }
    }
}
