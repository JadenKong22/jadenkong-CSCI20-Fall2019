using System;

class MainClass {
  public static void Main (string[] args) {

    double temp1, Output;
    string choice1String, choice2String, choice1AmountString;



    Console.WriteLine ("What would you like to convert? Enter: F for fahrenheit, C for celsius, or K for kelvin.");
    choice1String = Console.ReadLine();

    Console.WriteLine ("Enter amount of " + choice1String);
    choice1AmountString = Console.ReadLine();
    temp1 = double.Parse(choice1AmountString);




   Console.WriteLine ("What would you like to convert TO? Enter: F for fahrenheit, C for celsius, or K for kelvin.");
    choice2String = Console.ReadLine();



        //converting from F to either C or K
        if (choice1String == "F")
    {

     if (choice2String == "C")
      {
      Output = temp1 - 32 * 5/9;
      Console.WriteLine(Output + " Degrees celsius");
      }

     if (choice2String == "K")
      {
      Output = temp1 - 32 * 5/9 + 273.15;
      Console.WriteLine(Output + " Kelvin");
      }


      }



          //converting from C to either F or K
          if (choice1String == "C")
    {

     if (choice2String == "F")
      {
      Output = temp1 * 9/5 + 32;
      Console.WriteLine(Output + " Degrees fahrenheit");
      }

     if (choice2String == "K")
      {
      Output = temp1 + 273.15;
      Console.WriteLine(Output + " Kelvin");
      }


      }



                //converting from K to either F or C
                if (choice1String == "K")
    {

     if (choice2String == "F")
      {
      Output = (temp1 - 273.15) * 9/5 + 32;
      Console.WriteLine(Output + " Degrees fahrenheit");
      }

     if (choice2String == "C")
      {
      Output = temp1 - 273.15;
      Console.WriteLine(Output + " Degrees celsius");
      }


      }
    

    



    
  }
}