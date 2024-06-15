using System;

class PuppyCare
{
    static void Main()
    {
        int foodPurchased = int.Parse(Console.ReadLine());

        int totalFoodEaten = 0;
        string command = Console.ReadLine();

        while (command != "Adopted")
        {
            int gramsEaten = int.Parse(command);
            totalFoodEaten += gramsEaten;

            command = Console.ReadLine();
        }

        int totalFoodEatenInGrams = totalFoodEaten;
        int foodLeft = foodPurchased * 1000 - totalFoodEatenInGrams; 

        if (foodLeft >= 0)
        {
            Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
        }
        else
        {
            int neededFood = Math.Abs(foodLeft);
            Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
        }
    }
}
