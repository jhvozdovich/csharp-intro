using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it for you!");
    string stringNum = Console.ReadLine();
    int yourNum = int.Parse(stringNum);
    int yourNumDoubled = yourNum *2;
    string stringNumDoubled = yourNumDoubled.ToString();
    Console.WriteLine("I doubled your number for you: " + stringNumDoubled);
  }
}