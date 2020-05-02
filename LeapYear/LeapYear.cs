using System;
class LeapYear
{
  static void Main()
  {
    Console.WriteLine("Year of birth?");
    string birthYear = Console.ReadLine();
    int birthYearNum = int.Parse(birthYear);
    Console.WriteLine("You were alive during these leap years:");
    for (int year = birthYearNum; year <= 2020; year++)
    {
      if(year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
  }
}