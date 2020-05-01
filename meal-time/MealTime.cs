using System;

class MealTime
{
  static void Main()
  {
    Console.WriteLine("What did you eat for breakfast?");
    string breakfast = Console.ReadLine();
    Console.WriteLine("You had " + breakfast + " for breakfast.");
    Console.WriteLine("What did you have for lunch?");
    string lunch = Console.ReadLine();
    Console.WriteLine("You had " + lunch + " for lunch.");
    Console.WriteLine("What did you have for dinner?");
    string dinner = Console.ReadLine();
    Console.WriteLine("You had " + dinner + " for dinner.");
  }
}