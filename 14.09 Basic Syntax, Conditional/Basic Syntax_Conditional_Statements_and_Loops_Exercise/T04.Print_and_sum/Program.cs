using System;

namespace T04.Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инт две числа старт и край на последователност
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=start; i<=end; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");


            //принтират се два реда
            //	On the first line, print all numbers from the start of the sequence to the end inclusive
            //	On the second line, print the sum of the sequence in the format: "Sum: {sum}"

        }
    }
}
