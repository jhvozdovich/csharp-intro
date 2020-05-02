using System;
class GroceryList
{
  static void Main()
  {
    string[] myList = {"eggs", "yogurt", "granola", "cheese", "snacks", "pears"};
    Console.WriteLine("Grocery list:");
    int[] groceryPrices = {4, 3, 6, 5, 10, 6};
    // foreach (string item in myList)
    for (int i= 0; i < myList.Length; i++)
    {
      Console.WriteLine(myList[i]);
    }
    int total = 0;
    // foreach (int price in groceryPrices)
    for (int i=0; i < groceryPrices.Length; i++)
    {
      total += groceryPrices[i];
    }
    Console.WriteLine("Your total is: $" + total);
  }
}