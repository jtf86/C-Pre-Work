using System;

class GroceryList {
  static void Main() {
    string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice" };
    int[] groceryListPrices = { 3, 6, 4, 2, 4, 4};

    Console.WriteLine("My grocery list:");
    for (int index = 0; index < myGroceryList.Length; index++) {
      Console.WriteLine(myGroceryList[index]);
    }
  }
}
