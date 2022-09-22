using System;

namespace T5.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());//променлива за въведеното число
            for (int i = 1; i <= num; i++)//цикъл, който преминава от 1 до въведеното число
            {
                int sum = 0;//променлива за сумата на цифрите

                int currentNumber = i;//променлива за моментното число, на което е спрял броячът
                while (currentNumber > 0)//вътр.цикъл който върви, докато броячът е по-голям от нула
                {
                    sum += currentNumber % 10;//сумата е равна и се прибавя брояча модулно разделен на 10
                    currentNumber /= 10;//
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
