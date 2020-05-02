using System;
class FirstLetterChecker
{
  static void Main()
  {
    Console.WriteLine("What's your name?");
    string name = Console.ReadLine();
    if (name.StartsWith("Z") || name.StartsWith("z")) {
      Console.WriteLine("Your name starts with Z!");
    } else
    {
      Console.WriteLine("Sorry your name doesn't start with Z!");
    }
  }
}