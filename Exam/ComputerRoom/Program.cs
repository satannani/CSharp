using System;

class ComputerRoom
{
    static void Main()
    {

        string month = Console.ReadLine().ToLower();
        int hoursSpent = int.Parse(Console.ReadLine());
        int groupSize = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine().ToLower();

        
        double pricePerHour = 0.0;

        if (month == "march" || month == "april" || month == "may")
        {
            if (timeOfDay == "day")
            {
                pricePerHour = 10.50;
            }
            else if (timeOfDay == "night")
            {
                pricePerHour = 8.40;
            }
        }
        else if (month == "june" || month == "july" || month == "august")
        {
            if (timeOfDay == "day")
            {
                pricePerHour = 12.60;
            }
            else if (timeOfDay == "night")
            {
                pricePerHour = 10.20;
            }
        }

        //discounts
        if (groupSize >= 4)
        {
            pricePerHour *= 0.90; // 10% disc.
        }
        if (hoursSpent >= 5)
        {
            pricePerHour *= 0.50; // 50% disc.
        }

        //total cost
        double totalCost = pricePerHour * groupSize * hoursSpent;

        
        Console.WriteLine($"Price per person for one hour: {pricePerHour:F2}");
        Console.WriteLine($"Total cost of the visit: {totalCost:F2}");
    }
}
