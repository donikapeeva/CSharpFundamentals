using System;

namespace T11.MultiplicationTable_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //два инпута цели числа
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;

            if (num2 <= 10)
            {
                for (int i = num2; i <= 10; i++)
                {
                    sum = num1 * i;
                    Console.WriteLine($"{num1} X {i} = {sum}");

                }
            }
            else
            {
                sum = num1 * num2;
                Console.WriteLine($"{num1} X {num2} = {sum}");
            }
            
        }
    }
}
