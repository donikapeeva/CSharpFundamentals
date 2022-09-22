using System;

namespace T07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line you will receive the type of day.
            string dayType = Console.ReadLine();
            //On the second – the age of the person.
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            //      Day / Age	0 <= age <= 18	18 < age <= 64	64 < age <= 122
            //      Weekday          12$	         18$	         12$
            //      Weekend          15$	         20$	         15$
            //      Holiday           5$	         12$	         10$
            if (dayType== "Weekday")
            {
                if(age >=0 && age <= 18)
                {
                    price = 12;
                }
                if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                }
                
            }
            if (dayType == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
               
            }
            else if (dayType == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                
            }
            if (price != 0)
            {
                Console.WriteLine(price + "$");   
            }
            else
            {
                Console.WriteLine("Error!");
            }
            


        }
    }
}
