using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorableAreas
{
    public class Locations
    {

        public string Name = "";
        public string Description = "";
        public List<Item> Items = new List<Item>();
        public ConsoleColor LocationColor = new ConsoleColor();

      
        public Locations(string name, string description, List<Item> items) 
        {
            Name = name;
            Description = description;
            Items = items;
            LocationColor = ConsoleColor.DarkBlue; 
        }
        public Locations(string name, string description, List<Item> items, ConsoleColor color)
        {
            Name = name;
            Description = description;
            Items = items;
            LocationColor = color; 
        }
        public string About() 
        {
            return $"{Name}: {Description}"; 
        }
    }
}