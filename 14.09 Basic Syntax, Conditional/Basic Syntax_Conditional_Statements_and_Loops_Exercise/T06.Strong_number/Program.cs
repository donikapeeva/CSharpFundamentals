using System;

namespace T06.Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се цяло число
            int number = int.Parse(Console.ReadLine());
            //променлива, която да ни пази това число
            int copyNumber = number;
            int facturialSum = 0;
            //цикъл, който минава през числото и маха последната цифра.
            while (copyNumber > 0) //докато числото е по-голямо от нула
            {
                int lastDigit = copyNumber % 10; //променлива за последната цифра. с модулно деление на 10 получаваме резултат последната цифра
                copyNumber = copyNumber / 10; //целоцифрено деление на 10, за да премахнем последната цифра и цикъла да дели числото без последната цифра на следващото завъртане

                int factorial = 1; //променлива за факториела
                //цикъл, който започва от 1 и върви докато е по-малко или равно на последната цифра
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial = factorial * i;
                }
                //събиране на фактoриeлите
                facturialSum += factorial;
            }
            if (facturialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

                
            //пресмятане дали е strong. То е, ако сумата от факториелите на всяка цифра е равна на самото число.
        }
    }
}
