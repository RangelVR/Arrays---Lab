using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int numOfDay = input - 1;
            string day = string.Empty;

            string[] daysOfWeak = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
            "Saturday", "Sunday"};
            

            for (int i = 0; i <= daysOfWeak.Length - 1; i++)
            {
                int index = i;

                if (index == numOfDay)
                {
                    day = daysOfWeak[i];
                    Console.WriteLine(day);
                }
                
            }
            
        }
    }
}
