using System;
class HotelCost 
{
  static void Main()
  {
    Console.WriteLine("Season to book?");
    string season = Console.ReadLine();
    Console.WriteLine("Weekend or weeknight?");
    string day = Console.ReadLine();
    bool summer = season == "summer";
    bool weekend = day == "weekend";

    if (summer && weekend) 
    {
      Console.WriteLine("Peak travel and weekend - more expensive.");
    }
    else if (summer)
    {
      Console.WriteLine("Summer is expensive.");
    }
    else if (weekend)
    {
      Console.WriteLine("Weekends are expensive.");
    }
    else {
      Console.WriteLine("Could be worse.");
    }
  }
}