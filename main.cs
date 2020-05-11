using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Giraffe\nAcademy");
    // \n creates a new line
    Console.WriteLine ("\"Giraffe\" Academy");
    // using \ will allow "" to print out
    string phrase = "Giraffe Academy";
    Console.WriteLine(phrase.Length);
    //tells how many characters are inside the string
    Console.WriteLine(phrase.ToUpper());
    //makes the string all uppercase
    Console.WriteLine(phrase.ToLower());
    //makes the string all lowercase
    Console.WriteLine(phrase.Contains("Academy"));
    //checks to see if string contains the phrase academy, will return true, it is case sensitive
    Console.WriteLine(phrase[0]);
    //prints out first index of the string, first index is in position 0
    Console.WriteLine(phrase.IndexOf("Academy"));
    //Academy starts at index position 8
    Console.WriteLine(phrase.IndexOf('f'));
    //will let us know which index the letter f located
    Console.WriteLine(phrase.Substring(8, 3));
    //will print out with the index number provided, the 2nd number lets you put a limit of how many characters to print out *second number isnt needed
  }
}