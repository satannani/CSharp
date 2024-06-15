using System;

class MiningRig
{
    static void Main()
    {
        int pricePerVideoCard = int.Parse(Console.ReadLine());
        int pricePerAdapter = int.Parse(Console.ReadLine());
        double dailyElectricityCostPerCard = double.Parse(Console.ReadLine());
        double dailyProfitPerCard = double.Parse(Console.ReadLine());
        // constant values used
        int numberOfVideoCards = 13;
        int numberOfAdapters = 13;
        int otherComponentsCost = 1000;

        // calculation of the total costs
        int totalCostOfVideoCards = numberOfVideoCards * pricePerVideoCard;
        int totalCostOfAdapters = numberOfAdapters * pricePerAdapter;
        int totalInitialInvestment = totalCostOfVideoCards + totalCostOfAdapters + otherComponentsCost;

        // daily profit / after electrical bill
        double netDailyProfitPerCard = dailyProfitPerCard - dailyElectricityCostPerCard;
        double totalDailyProfit = numberOfVideoCards * netDailyProfitPerCard;

        // payback period 
        double paybackPeriod = totalInitialInvestment / totalDailyProfit;

      
        Console.WriteLine(totalInitialInvestment);
        Console.WriteLine(Math.Ceiling(paybackPeriod));
    }
}