using System;

namespace T07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //до командата start машината приема монети, но само валидните се приемат
            string input = string.Empty; //променлива за въвеждания инпут стринг
            double sum = 0;//променлива за сумата пуснати монети
            double coins = 0;//променлива за монетите
            while ((input = Console.ReadLine())!= "Start") //цикъл с четене на стринговия инпут, който върви до команда старт
            {
                coins = double.Parse(input); //преобразуване на стринга в число за монетите
                //валидните са 	0.1, 0.2, 0.5, 1 and 2
                if (coins == 2) 
                {
                    sum += coins;//монетите се добавят към сумата
                }
                else if (coins == 1)
                {
                    sum += coins;
                }
                else if (coins == 0.5)
                {
                    sum += coins;
                }
                else if (coins == 0.2)
                {
                    sum += coins;
                }
                else if (coins == 0.1)
                {
                    sum += coins;
                }
                else //ако се въведе невалидна монета, се принтира "Cannot accept {money}"  и се минава на следващ ред
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }  
            }
            //на следващите редове, до команда "End" се въвежда продукт, който клиента иска да купи
            string product = Console.ReadLine();
            double priceProduct = 0;
            while(product!= "End") 
            {
                switch (product)
                {
                    case "Nuts": //	"Nuts" with a price of 2.0
                        priceProduct = 2.0;
                        break;
                    case "Water":  //	"Water" with a price of 0.7
                        priceProduct = 0.7;
                        break;
                    case "Crisps":  //	"Crisps" with a price of 1.5
                        priceProduct = 1.5;
                        break;
                    case "Soda":  //	"Soda" with a price of 0.8
                        priceProduct = 0.8;
                        break;
                    case "Coke":   //	"Coke" with a price of 1.0
                        priceProduct = 1.0;
                        break;
                    default:    //ако клиента въведе несъществуващ продукт се изписва "Invalid product".
                        Console.WriteLine("Invalid product");
                        break;
                }
                if(sum>=priceProduct)
                {  //когато клиента има достатъчно пари да купи продукт price== сбора на парите се принтира "Purchased {product name}"
                    sum -= priceProduct;
                    Console.WriteLine("Purchased {product}");
                    priceProduct = 0;
                }
                else if (priceProduct > sum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");            
            
             
            //ако не може да плати продукта или още продукти се принтира "Sorry, not enough money" и отива на нов ред
            //ако при команда end е останало ресто, се принтира "Change: {money left}" до втория знак.

        }
    }
}
