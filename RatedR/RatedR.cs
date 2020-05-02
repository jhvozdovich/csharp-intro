using System;

class RatedR
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    string stringAge = Console.ReadLine();
    int age = int.Parse(stringAge);

    if (age >= 17) {
      Console.WriteLine("Welcome to the movie!");
    }
    else{
      Console.WriteLine("You're a baby! You can't watch this!");
    }
  }
}