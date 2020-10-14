using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System;

namespace FörstaProvet
{
    public class Book
    {
        public int price;
        private string name = "Name";
        private int rarity;
        private string category = "Kateorig";
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();

        

        public Book()
        {
            /*Det här kodblocket är en konsturktor
              Det som står i den här koden är de bas-stats som böcker som skapas har. 
              Den använder en slump generator för actualValue och Rarity
              
              och en slumpgenerator som är en 50/50 om den är cursed eller inte. */
            
            actualValue = generator.Next(100, 1000);
            rarity = generator.Next(1,11);

            int CursedOrNot = generator.Next(1,3); 
            if(CursedOrNot == 1)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }

            
            //slumpar ett tal mellan 0-2 och sedan drar den ut en från listan och sätter name till det
            //Likadant för kategorier.
            int slumpaNamn = generator.Next(0,3);
            List<string> namnLista = new List<string>() {"namn1", "namn2", "namn3"};
            name = namnLista[slumpaNamn];

            int slumpaKateogri = generator.Next(0,3);
             List<string> kategoriLista = new List<string>() {"kategori", "kategori2", "kategori3"};
            name = kategoriLista[slumpaNamn];

        }

        public void PrintInfo() //KLAR
        { 
            //Det här blocket skriver ut de olika stats som boken man har skapat har. 
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Rarity: " + rarity);
            System.Console.WriteLine("Category: " + category);
            System.Console.WriteLine("Price: " + price);


            System.Console.WriteLine("cursed: " + cursed);
        }

        public int Evaluate() //KLAR
        {
            //det här blocket börjar då att sätta ett pris genom att multiplicera actualValue och Rarity
            //den slumpar även mellan 50 - 151 för att sedan visa priset, vilket är mellan 50% och 150% av "price"
            //den tar sedan price / 100 för att få rätt % sats. 
            price = actualValue * rarity;
            
            int slumptal = generator.Next(50, 151);
            price = (price * slumptal);
            price = (price/100);

            return price;
            
        }
        

        public string GetCategory() //KLAR
        {
            //Skrivet ut kategorin
            return category;
        }

        public string GetName()//KLAR 
        {
            //skriver ut namnet
            return name;
        }

        public bool IsCursed()
        {
           //Den slumpar mellan 1-5 och om det blir en etta kollar den om boken är cursed eller inte.
           //Om den är cursed returnar den false då den ska ljuga om det hamnar på 1.
           //Är den inte cursed så skriver den att den är cursed, då den ska ljuga om den hamnar på 1.
           //Om den inte hamnar på 1 ska den returna cursed. 

            int slumptal= generator.Next(1,6);
            
            if(slumptal == 1)
            {
                if(cursed == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return cursed;
            }

        }

    }
}
