using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};
  

    int[] groceryListCost = {3, 6, 4, 2, 4, 4};

    Console.WriteLine("My grocery list:");

    for(int index = 0; index<myGroceryList.length; index++) 
    {
      Console.WriteLine(myGroceryList[index]);
    }

    // foreach (string groceryItem in myGroceryList) 
    // {
    //   Console.WriteLine(groceryItem);
    // }

    int total = 0;
    foreach (int price in groceryListCost)
    {
      total = total += price;
    }
    Console.WriteLine("Your total for this shopping trip will be: " + total);
  }
}