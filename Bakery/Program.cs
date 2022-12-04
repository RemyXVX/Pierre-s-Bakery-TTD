using System;
using PierreBakes.Models;

namespace PierreBakes
{
  public class Progam
  {
    public static void Main()
    {
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine("//////////////////////////////////////////////////");
      Console.WriteLine("Welcome to land of carbs, this be Pierre's Bakery!");
      Console.WriteLine("//////////////////////////////////////////////////");
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine("//////////////////////////////////////////////////");
      Console.WriteLine(" ----- We have bake goods for sale!!");
      Console.WriteLine(" ----- Our bread starting at $5");
      Console.WriteLine(" ----- Or try our pastry for $2 a pop!");
      Console.WriteLine("//////////////////////////////////////////////////");
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine("//////////////////////////////////////////////////");
      Console.WriteLine("!!~~!! SPECIAL IF YOU BUY MUTLIPLE AT A TIME !!~~!!");
      Console.WriteLine("//////////////////////////////////////////////////");
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine("So, are you intrested on getting some? \n(Enter 'Y' for yes, enter to exit)");
      string order = Console.ReadLine();

      if (order == "y" || order == "Y")
      {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Welcome!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");

        Console.WriteLine("How many loafs of bread are we getting?");
        int QuantityOfBread;
        int breadInput = int.Parse(Console.ReadLine());
        if (breadInput >= 1)
        {
          Console.WriteLine("It's coming up!");
        }
        else
        {
          Console.WriteLine("Yo, I don't have all day!")
        }
        Bread newBread = new Bread(QuantityOfBread);
        int loafTotal = newBread.MultiBread();
        Console.WriteLine("Bread Total: $" + loafTotal);

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");

        Console.WriteLine("How many pastryies are we getting?");
        int QuantityOfPastry;
        int pastryInput = int.Parse(Console.ReadLine());
        if (pastryInput >= 1)
        {
          Console.WriteLine("It's coming up!");
        }
        else
        {
          Console.WriteLine("Yo, I don't have all day!")
        }
        Pastry newPastry = new Pastry (QuantityOfPastry);
        int pastryTotal = newPastry.MultiPastry();
        Console.WriteLine("Pastry Total: $" + pastryTotal);
      
      }
      else
      {
        Console.WriteLine("See ya later fooo!");
      }
    }
  }
}