using System;

namespace Т10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инпут цяло число
            int n = int.Parse(Console.ReadLine());
            int sum = n;
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine($"{n} X {i} = {sum}");
                sum +=n;

            }

        }
    }
}
