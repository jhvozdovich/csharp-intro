using System;
class GroceryList
{
  static void Main()
  {
    string[] myList = {"eggs", "yogurt", "granola", "cheese", "snacks", "pears"};
    Console.WriteLine("Grocery list:");
    int[] groceryPrices = {4, 3, 6, 5, 10, 6};
    foreach (string item in myList)
    {
      Console.WriteLine(item);
    }
    int total = 0;
    foreach (int price in groceryPrices)
    {
      total += price;
    }
    Console.WriteLine("Your total is: $" + total);
  }
}