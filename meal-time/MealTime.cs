using System;

class MealTime
{
  static void MealInputOutput(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
    string mealInput = Console.ReadLine();
    Console.WriteLine("You had " + mealInput + " for " + meal + ".");
  }
  static void Main()
  {
    MealInputOutput("breakfast");
    MealInputOutput("lunch");
    MealInputOutput("dinner");
  }
}