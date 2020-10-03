// ---------------- Coin Counter -------------

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("Enter an amount to convert to coins:");
      string totalAsString = Console.ReadLine();
      double myAmountAsDouble = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{myAmountAsDouble} cents is equal to...");

      int goldValue = 10;
      int silverValue = 5;

      double goldCoins = Math.Floor(myAmountAsDouble / goldValue); 
      double reFromGold = myAmountAsDouble % goldValue;
      double silverCoins = Math.Floor(reFromGold / silverValue);
      double bronzeCoins = reFromGold % silverValue;

      Console.WriteLine($"{goldCoins} Gold coin");
      Console.WriteLine($"{silverCoins} Silver coin");
      Console.WriteLine($"{bronzeCoins} Bronze coin");

      
    }
  }
}