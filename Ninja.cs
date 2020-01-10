using System.Collections.Generic;

class Ninja 
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public bool IsFull { 
            get { 
                if(calorieIntake > 1200){
                    System.Console.WriteLine("Ninja is now full. Can't eat any more.");
                    return true; 
                } else {
                    return false;
                }
            } 
        }

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public int Eat(Food item)
        {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                string phrase = item.Name;

                if(item.IsSpicy){
                    phrase += " is spicy";
                } else {
                    phrase += " is sweet";
                }
                System.Console.WriteLine(phrase);
            }
            System.Console.WriteLine("Calorie count:" + calorieIntake);
            return calorieIntake;
        }
    }