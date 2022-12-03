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

      if (order == "y")
      {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("What are we getting?");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");
      }
      else
      {
        Console.WriteLine("See ya later fooo!");
      }
    }
  }
}