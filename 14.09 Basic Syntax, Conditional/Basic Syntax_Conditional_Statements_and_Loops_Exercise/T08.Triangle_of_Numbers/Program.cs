using System;

namespace T08.Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инт н число инпут
            int n = int.Parse(Console.ReadLine());
            //програма, която принтира триъгълник от числата от 1 до n , като n може да е число от 1 до 20
            //цикъл за редове
            for (int countRow = 1; countRow <= n; countRow++)//цикъл, който се върти от брояча/реда 1 и спира, докато брояча/реда е по-малко или равно на въведеното число. Брояча/реда се увеличава
            {
                //цикъл за колони(всяко число на ред)
                for (int countNum = 1; countNum <= countRow; countNum++)//още един цикъл, който e за изписаните числа на ред
                    //броячът/цифрата започват от 1 и се въртят, докато са по-малки или равни на числото на редовете. Броячът/цифрата се увеличават при всяко завъртане
                {
                    Console.Write($"{countRow} ");//отпечатване на числото, което съвпада с номера на реда
                    
                }
                Console.WriteLine();//преминаване на нов ред
            }
        }
    }
}
