using System;

namespace FörstaProvet
{
    class Program
    {
        static void Main(string[] args)
        {
            //instans av klassen Book.cs 
            Book boken = new Book();
            Kunden kunden = new Kunden();
            
            //Det här är en While-Loop som kommer köras föralltid
            //Jag har inte tiden att göra något som innehåller mer än en bok.
            //Den kollar 
            bool GameOver = false;
            while(GameOver == false)
            {
                Console.WriteLine("What do you want to do?");
                string svar = Console.ReadLine();
                if(svar == "information")
                {
                    boken.PrintInfo();
                }
                else if(svar == "evaluate")
                {
                    Console.WriteLine("The evaluated price is: " + boken.Evaluate());
                }
                else if(svar == "category")
                {
                    Console.WriteLine("The category of this book is: " + boken.GetCategory());
                }
                else if(svar == "Name")
                {
                    Console.WriteLine("The category of this book is: " + boken.GetName());
                }
                else if(svar == "cursed")
                {
                    if(boken.IsCursed() == true)
                    {
                        Console.WriteLine("This book is cursed");
                    }
                    else 
                    {
                        Console.WriteLine("This book is not cursed");
                    }
                }
                else{
                    Console.WriteLine("error");
                }
            }

            Console.ReadLine();
        }
    }
}
