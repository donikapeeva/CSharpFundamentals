

namespace T03.Vacation
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	A count of people who are going on vacation. Брой хора на ваканция
            int people = int.Parse(Console.ReadLine());
            //Type of the group(Students, Business or Regular). Тип група Студенти, бизнес, обикновена
            string groupType = Console.ReadLine();
            //The day of the week which the group will stay on(Friday, Saturday or Sunday). Ден от седмицата, в който групата ще остане
            string weekDay= Console.ReadLine();
            double sum = 0;
            double totalSum = 0;
            //              Цена за 1 човек!
            //                Friday   Saturday      Sunday
            //     Students    8.45     9.80        10.46
            //     Business    10.90    15.60        16
            //     Regular       15      20        22.50
            switch (groupType)
            {
                case "Students":
                    if (weekDay == "Friday")
                    {
                        // още намаления •
                        // 	For Students – ако групата е от 30 или повече човека, намалението на крайната сума е 15%
                        sum = people * 8.45;
                        if (people >= 30)
                        {
                            totalSum = sum - (sum * 0.15);
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    else if(weekDay == "Saturday")
                    {
                        sum = people * 9.80;
                        if (people >= 30)
                        {
                            totalSum = sum - (sum * 0.15);
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    else if (weekDay == "Sunday")
                    {
                        sum = people * 10.46;
                        if (people >= 30)
                        {
                            totalSum = sum - (sum * 0.15);
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    break;
                case "Business":
                    if (weekDay == "Friday")
                    {
                        //// още намаления •
                        //	For Business – ако групата е 100 или повече човека, 10 човека стоят безплатно.
                        sum = people * 10.90;
                        if (people >= 100)
                        {
                            totalSum = (people - 10) * 10.90;
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    else if (weekDay == "Saturday")
                    {
                        sum = people * 15.60;
                        if (people >= 100)
                        {
                            totalSum = (people - 10) * 15.60;
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    else if (weekDay == "Sunday")
                    {
                        sum = people * 16;
                        if (people >= 100)
                        {
                            totalSum = (people - 10) * 16;
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    break;
                case "Regular":
                    if (weekDay == "Friday")
                    {
                        // още намаления •
                        //	For Regular – ако групата е между 10 и 20 човек(и 10 и 20), има намаление 5% на крайната сума.
                        sum = people * 15;
                        if (people >= 10 && people <= 20)
                        {
                            totalSum = sum - (sum * 0.05);
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    else if (weekDay == "Saturday")
                    {
                        sum = people * 20;
                        if (people >= 10 && people <= 20)
                        {
                            totalSum = sum - (sum * 0.05);
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    else if (weekDay == "Sunday")
                    {
                        sum = people * 22.50;
                        if (people >= 10 && people <= 20)
                        {
                            totalSum = sum - (sum * 0.05);
                            Console.WriteLine($"Total price: {totalSum:f2}");
                            break;
                        }
                        Console.WriteLine($"Total price: {sum:f2}");
                    }
                    break;
            }
            
            //намалението се прилага точно в този ред

            //принтира се тоталната цена до втория знак
            // "Total price: {price}" 



        }
    }
}
