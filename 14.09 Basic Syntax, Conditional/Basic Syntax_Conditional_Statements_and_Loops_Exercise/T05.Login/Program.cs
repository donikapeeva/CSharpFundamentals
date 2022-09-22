using System;

namespace T05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се стринг за юзър
            string username = Console.ReadLine();
            //стринг парола
            string password = string.Empty;
            for(int i=username.Length-1; i >= 0; i--) //цикъл, който върви назад по юзърнейм и взима всеки символ
            {
                char currChar = username[i]; //променлива за всеки символ
                password += currChar;//паролата подрежда символа отзад напред в нова дума
            }
            int counter = 1;//брояч на опитите на паролата
            string enteredPassword; //string за въведена парола
            //цикъл, който върви докато се чете въведената парола и тя е различна от желаната парола. Спира, когато counter стане 4
            while((enteredPassword=Console.ReadLine()) != password)
            {
               
                if (counter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                counter++;
            }
            Console.WriteLine($"User {username} logged in.");

            //при грешна парола се принтира "Incorrect password. Try again." 
            //при вярна парола се принтира "User {username} logged in." и спира
            //програмата спира на четвърти опит и се принтира "User {username} blocked!".
        }
    }
}
