using System;

namespace T12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инпут число
            int number = int.Parse(Console.ReadLine());

            //цикъл докато не се въведе четно число, тогава спира
            while (number % 2 != 0)
            {
                
                Console.WriteLine("Please write an even number.");
                number++;
                number = int.Parse(Console.ReadLine());
            }
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
            }
        }
    }
}
