using System;

namespace Fundamentals_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //инпут брой числа
            int n = int.Parse(Console.ReadLine());
            int sum = 0; //сбор от нечетните числа
            int counter = 0;//брояч

            for (int i = 1; i <= 100; i += 2) //цикъл за преминаване през нечетните числа, от 1 нагоре се прибавя по 2, за да се вземе нечетно
            {
                Console.WriteLine(i); //принтиране на нечетното i 
                counter++; //броячът се увеличава
                sum += i; //събиране на сумата от нечетни числа

                if (counter == n)//ако броячът се изравни с n
                {
                    Console.WriteLine($"Sum: {sum}");//принтира се сумата и се спира цикъла
                    break;
                }
            }

        }
    }
}