using System;

class PingPong {
  static void Main() {
    Console.WriteLine("Please enter your Ping Pong digit. Do not fail me.");
    string inputNumber = Console.ReadLine();
    int myNumber = int.Parse(inputNumber);

    Console.WriteLine("Heed and take warning. Now follows your solution.");
    for (int x = 1; x <= myNumber; x++) {
      if (x % 15 == 0) {
        Console.WriteLine("Ping Pong Muthafooka!");
      } else if (x % 5 == 0) {
        Console.WriteLine("Pong");
      } else if (x % 3 == 0) {
        Console.WriteLine("Ping");
      } else {
        Console.WriteLine(x);
      }
    }
  }
}
