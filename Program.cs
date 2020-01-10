using System;
using System.Collections.Generic;

/*
    Task: Createa a Food, Ninja, Buffet class
*/

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja ninja = new Ninja();

            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
        }
    }

    
}
