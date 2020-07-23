using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace ExplorableAreas
{
    public class Person
    {
        public string Name = "Anonymous Player";
        public List<Item> Inventory;
      

        public Person(string name, List<Item> inventory) 
        {
            if (name != "")
            { Name = name; }
            else
            { Name = "Anonymous Explorer"; }

            Inventory = inventory;
        }
      
    }
}