using System;
using System.Collections.Generic;


class Riddles
{
  public static Dictionary<string, string> riddles = new Dictionary<string, string>(){{"bubble gum","What goes in hard, comes out soft, and you blow continuously?"},{"left hand","What can you hold in your right hand, but not in your left?"}};


  static void Main()
  {
    Console.WriteLine(riddles["bubble gum"]);
    string yourRiddleAnswer = Console.ReadLine();
    if(yourRiddleAnswer == "bubble gum" || yourRiddleAnswer == "Bubble Gum" || yourRiddleAnswer == "Bubblegum")
    {
      Console.WriteLine("You right, you right! Keep going?['Y' for yes, 'N' for no.]");
      string nextRiddle = Console.ReadLine();
      if(nextRiddle == "y" || nextRiddle == "Y")
      {
        Console.WriteLine(riddles["left hand"]);
        string nextRiddleAnswer = Console.ReadLine();
        if(nextRiddleAnswer == "left hand" || nextRiddleAnswer == "Left Hand")
        {
          Console.WriteLine("You right, you right!, that is all.");
        }
            // else {
            //   Console.WriteLine("Eaten! Try again");
            // }


        else{
          Console.WriteLine("Eaten! Try again? ['Y' for yes, 'N' for no.]");
          string nextRiddle1 = Console.ReadLine();
          if(nextRiddle1 == "y" || nextRiddle1 == "Y")
          {
          Main();
          }
        }
      }
    }
  }
}
