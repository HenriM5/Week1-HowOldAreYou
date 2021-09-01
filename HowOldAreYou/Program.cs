using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who dis");
            //ReadLine() to read the user input from the console
            string Username = Console.ReadLine();
            Console.WriteLine("Hello," + Username + "!");
            Console.WriteLine("How old are you tho? Enter digits only:");
            int age = Int16.Parse(Console.ReadLine());
            int YearOfBirth = 2021 - age;
            Console.WriteLine("You were born in" + YearOfBirth);
            string UserName = Console.ReadLine();
            Console.WriteLine("Ah damn, sorry.");
            string username = Console.ReadLine();
           
           
            
            
            





        }

    }
}
