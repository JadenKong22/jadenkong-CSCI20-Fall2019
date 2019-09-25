//Jaden Kong
//9/23/19
//Comnination Lock

using System;

class MainClass {
  public static void Main (string[] args) {

#region variable declaration

string number1String, number2String, number3String;
double number1, number2, number3, count;

count = 0;
number1 = 0;
number2 = 0;
number3 = 0;

#endregion

#region while loop

Console.WriteLine ("\nEnter 3 numbers between 1 and 5. If you guess these numbers correctly,you will unlock the  lock and win a prize!");

  while (count < 3)

  {


    Console.WriteLine ("\nEnter your first number ");
    number1String = Console.ReadLine();
    number1 = double.Parse(number1String);



    Console.WriteLine ("\nEnter your second number ");
    number2String = Console.ReadLine();
    number2 = double.Parse(number2String);



    Console.WriteLine ("\nEnter your third number ");
    number3String = Console.ReadLine();
    number3 = double.Parse(number3String);

    count = 3;

      if (number1 == 1 && number2 == 2 && number3 == 3)
      {

            Console.WriteLine("\nCongratulations! You have won! Unfortunately we're all out of prizes :(");

      }

      if (number1 != 1 || number2 != 2 || number3 != 3)
      {
      Console.WriteLine("WRONG! Try again.");
      count = 0;
      continue;
      }


  }

#endregion

  }

}
