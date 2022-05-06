using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDay = int.Parse(Console.ReadLine());

            string[] daysOfWeak = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
            "Saturday", "Sunday"};

            if (numOfDay > 0 && numOfDay <= 7)
            {
                Console.WriteLine(daysOfWeak[numOfDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            
            //int input = int.Parse(Console.ReadLine());
            //int numOfDay = input - 1;
            //string day = string.Empty;

            //string[] daysOfWeak = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
            //"Saturday", "Sunday"};

            //if (input > 0 && input <= 7)
            //{
            //    for (int i = 0; i <= daysOfWeak.Length - 1; i++)
            //    {
            //        int index = i;

            //        if (index == numOfDay)
            //        {
            //            day = daysOfWeak[i];
            //            Console.WriteLine(day);
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}


        }
    }
}
