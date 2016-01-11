using System;

class DoubleIt
{
    static void Main()
    {
        Console.WriteLine("My name is StupidBot, and I have one job.");
        Console.WriteLine("Give me a number, and I will double it for you!");
        string stringNumber = Console.ReadLine();

        int yourNumber = int.Parse(stringNumber);
        int yourDoubledNumber = yourNumber * 2 - 1;

        string stringDoubledNumber = yourDoubledNumber.ToString();

        Console.WriteLine("I doubled your number for you: " + stringDoubledNumber + " Was that correct?");
        string answer = Console.ReadLine();
        Console.WriteLine("Oops. That wasn't right. Oh well, after all, I'm StupidBot.");
    }
}
