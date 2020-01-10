using System;
using System.Collections.Generic;

class Buffet
    {
        public List<Food> Menu;
        
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Apple", 100, false, false),
                new Food("Banana", 200, true, false),
                new Food("Carrot", 300, false, true),
                new Food("Dogfood", 400, true, true),
                new Food("Eggplant", 500, false, false),
                new Food("Frozen Nuggets", 250, false, false)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }