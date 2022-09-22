using System;

namespace T10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   On the first input line – lost games count – integer in the range[0…1000].
            int lostGames = int.Parse(Console.ReadLine());
            //	On the second line – headset price – floating - point number in the range[0…1000].
            double headsetPrice = double.Parse(Console.ReadLine());
            //	On the third line – mouse price – floating - point number in the range[0…1000].
            double mousePrice = double.Parse(Console.ReadLine());
            //	On the fourth line – keyboard price – floating - point number in the range[0…1000].
            double keyboardPrice = double.Parse(Console.ReadLine());
            //	On the fifth line – display price – floating - point number in the range[0… 1000].
            double displayPrice = double.Parse(Console.ReadLine());

            // Всяка втора загубена игра, Петър удря headset
            //всяка трета загубена игра, Петър удря мишката си
            //Когато се случи да удря едновременно мишка и слушалки в една загубена игра(напр.всяка шеста)той си удря и клавиатурата
            //всеки втори път, когато си удари клавиатурата, той си удря и дисплея
            int countHeadset = 0;//променлива за брояча на ударите на слушалките
            int countMouse = 0; //променлива за брояча на ударите на мишката
            int countKeyboard = 0;//променлива за брояча на ударите на клавиатурата
            int countDisplay = 0; //променлива за брояча на ударите на дисплея
            for (int i = 1; i <=lostGames; i++)//цикъл с брояч, който върви от 1, докато е по-малко или равно на загубените игри
            {
                if (i % 2 == 0)//иф проверка за всяка втора игра(четна)
                {
                    countHeadset++; //преброяване колко пъти си удря слушалките 
                }
                if (i % 3 == 0) //всяка трета игра
                {
                    countMouse++; //преброяване колко пъти си удря мишката,
                }
                if(i%2==0 && i % 3 == 0) //преброяване колко пъти си удря клавиатура,
                {
                    countKeyboard++;//всяка шеста игра
                }
                if (i % 12 == 0)//преброяване на ударите на дисплей, всеки втори път, когато удря клавиатура 6*2=12
                {
                    countDisplay++;
                }
            }
            // събиране на всяка цена и пресмятане на общата сума на щетите
            double totalRageExpens = (countHeadset * headsetPrice) + (countMouse * mousePrice) + (countKeyboard * keyboardPrice) + (countDisplay * displayPrice);


            //Принтиране на "Rage expenses: {expenses} lv.".
            Console.WriteLine($"Rage expenses: {totalRageExpens:f2} lv.");
        }
    }
}
