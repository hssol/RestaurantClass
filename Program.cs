using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        class Food
        {
            public string Name;
            public int Calories;
            public bool IsSpicy;
            public bool IsSweet;
            public Food(string name, int calories, bool Spicy, bool Sweet)
            {
                Name = name;
                Calories = calories;
                IsSpicy = Spicy;
                IsSweet = Sweet;
            }
        }
        class Buffet
        {
            public List<Food> Menu;
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Pizza", 1000, false, false),
                    new Food("Spaghetti", 800, false, false),
                    new Food("Cookie", 100, false, true),
                    new Food("Ice Cream", 400, false, true),
                    new Food("Sushi", 200, true, false),
                    new Food("Ramen", 900, true, false),
                    new Food("Sandwich", 600, false, false)
                };
            }
            public Food Serve()
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0,6);
                Console.WriteLine(Menu[randomNumber].Name);
                return Menu[randomNumber];
            }
        }
        class Ninja
        {
            private int calorieIntake;
            public bool IsFull
            {
                get {  
                    if (calorieIntake > 1200)
                    {   
                        return true;
                    }
                    else
                    {
                        return false;
                    } 
                }
            }

            public List<Food> FoodHistory;

            public Ninja()
            {
                calorieIntake = 0;
                FoodHistory = new List<Food>();
            }
            public void Eat()
            {
                if (IsFull)
                {
                    Console.WriteLine("Ninja is full");
                }
                else
                {
                    Buffet currentBuffet = new Buffet();
                    Food dish = currentBuffet.Serve();
                    FoodHistory.Add(dish);
                    calorieIntake += dish.Calories;
                    if (IsFull)
                    {
                        Console.WriteLine($"Ninja is full after eating {calorieIntake} calories!");
                    }
                    else
                    {
                        Console.WriteLine($"Calorie intake so far: {calorieIntake}");
                    }
                    
                }
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            Ninja Sam = new Ninja();
            Sam.Eat();
            Sam.Eat();
            Sam.Eat();
        }
    }
}
