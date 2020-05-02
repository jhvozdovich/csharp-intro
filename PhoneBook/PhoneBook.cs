using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNums = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phonebook? Y/N?");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AddContact();
    }
    else{
      Console.WriteLine("Would you like to look up someone? Y/N?");
      string find = Console.ReadLine();
      if (find == "y" || find == "Y")
      {
        LookUpContact();
      }
      else
      {
        Console.WriteLine("Are you finished? Y/N?");
        string done = Console.ReadLine();
        if (done == "Y" || done == "y")
        {
          Console.WriteLine("Bye!");
        }
        else{
          Main();
        }
      }
    }
  }

  static void AddContact() {
    Console.WriteLine("NEW CONTACT");
    Console.WriteLine("Enter a new contact name");
    string name = Console.ReadLine();
    Console.WriteLine("Eneter their phone number");
    string number = Console.ReadLine();
    if (phoneNums.ContainsKey(name))
    {
      Console.WriteLine("That person is already in your phonebook with a number of " + phoneNums[name]);
    }
    else
    {
      phoneNums.Add(name, number);
    }
    Main();
  }

  static void LookUpContact()
  {
    Console.WriteLine("CONTACT LOOKUP");
    Console.WriteLine("Who are you looking for?");
    string findContact = Console.ReadLine();
    if (phoneNums.ContainsKey(findContact))
    {
      string foundNum = phoneNums[findContact];
      Console.WriteLine(findContact + "\'s phone number is " + foundNum);
    }
    else
    {
      Console.WriteLine("Could not find contact!");
    }
    Main();
  }
}