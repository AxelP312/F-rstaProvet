using System;
using System.Collections.Generic;

namespace FörstaProvet
{
    public class Kunden
    {
        private Random generator = new Random();
        public int money;

        public Kunden()
        {
            money = generator.Next(100,1000);
        }
    }
}
