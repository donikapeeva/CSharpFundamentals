using System;

namespace T04.Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	The first number is hours and will be between 0 and 23.
            int hour = int.Parse(Console.ReadLine());
            // The second number is minutes and will be between 0 and 59.
            int minutes = int.Parse(Console.ReadLine());
            int sumMinutes = minutes + 30;
            if (sumMinutes > 59)
            {
                hour += 1;
                sumMinutes -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{sumMinutes:D2}");


        }
    }
}
