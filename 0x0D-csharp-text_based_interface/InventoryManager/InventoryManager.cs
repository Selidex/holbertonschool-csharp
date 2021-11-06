using System;
using System.Collections.Generic;
using InventoryLibrary;
using System.Collections;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Inventory Manager\n" +
                            "-------------------------\n" +
                            "<ClassNames> show all ClassNames of objects\n" +
                            "<All> show all objects\n" +
                            "<All [ClassName]> show all objects of a ClassName\n" +
                            "<Create [ClassName]> a new object\n" +
                            "<Show [ClassName object_id]> an object\n" +
                            "<Update [ClassName object_id]> an object\n" +
                            "<Delete [ClassName object_id]> an object\n" +
                            "<Exit>";
            System.Console.WriteLine(prompt);
            
        }
    }
}
