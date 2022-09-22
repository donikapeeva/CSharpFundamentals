using System;

namespace T01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инпут години
            int age = int.Parse(Console.ReadLine());
            //според годините се определя дали човекът е baby, child, teenager, adult or elder
            
            //	>= 66 – elder
            if (age >= 66)
            {
                Console.WriteLine("elder");
            }
            //	20 - 65 – adult
            else if (age > 19)
            {
                Console.WriteLine("adult");
            }
            //	14 - 19 – teenager
            else if (age > 13)
            {
                Console.WriteLine("teenager");
            }
            //  3 - 13 – child
            else if (age > 2)
            {
                Console.WriteLine("child");
            }
            // 0-2 – baby
            if (age >= 0 && age<=2)
            {
                Console.WriteLine("baby");
            }

            //	All the values are inclusive.

        }
    }
}
