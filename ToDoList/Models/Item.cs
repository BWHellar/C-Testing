using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
      private string _description;
      private static List<Item> _instances = new List<Item> {};

      public Item (string description)
      {
          _description = description;
          _instances.Add(this);
      }

      public string GetDescription()
      {
          return _description;
      }

      public void SetDescription(string newDescription)
      {
          _description = newDescription;
      }
        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        
        public class Program
        {
        public static void Main()
        {
            Console.WriteLine("WELCOME TO THE TO DO LIST");
            Console.WriteLine("Welcome");
            StartLoop();    
        }
        public static void StartLoop()
        {
            Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");  
             string words = Console.ReadLine();
                if (words == "Add")
                {
                    Console.WriteLine("Add something to the list");
                    string answer = Console.ReadLine();
                    Item newItem = new Item(answer);
                    Console.WriteLine(answer + " added");
                }
                else if (words == "View")
                {
                    List<Item> myItems = Item.GetAll();
                        for (int i = 0; i < myItems.Count; i++)
                            Console.WriteLine( i + 1 + ": " + myItems[i].GetDescription());

                }
            StartLoop();
        }
    }
  }
}
