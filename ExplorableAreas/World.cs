using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Globalization;

namespace ExplorableAreas
{
    public class World
    {
        List<Locations> Locations;
        Person player;

        public World() 
        {
            SetUpWorld();
            SetUpPlayer();
            LocationMenu();
         
        }
        private void SetUpWorld() 
        {
            //list of locations
            Locations = new List<Locations>();

         
            WriteLine($"Wlcome to Explorable Areas by Hope Pham! Please enjoy your adventure!");

            List<Item> temp = new List<Item>();
            //mountains - ice, snowballs, coin, fish, gloves
            temp.Add(new Item("ice", "fresh ice."));
            temp.Add(new Item("snowballs", "fun and dangrous."));
            temp.Add(new Item("coin", "a shiny coin."));
            temp.Add(new Item("fish", "can be your friend or your next meal."));
            temp.Add(new Item("gloves", "used, but still wearable."));

            Locations.Add(new Locations("Tall Snowy Mountain","Very tall mountains and" +
                "\nvery cold. Steep and dangrous.", temp, ConsoleColor.DarkCyan));

            List<Item> temp2 = new List<Item>();
            //forest - axe, flashlight, sticks, rocks, berries
            temp2.Add(new Item("axe", "great for chopping down trees or logs into pieces."));
            temp2.Add(new Item("flashlight", "will come in handy at night."));
            temp2.Add(new Item("sticks", "can be used to start a fire pit."));
            temp2.Add(new Item("rocks", "another material to make a fire pit."));
            temp2.Add(new Item("berries", "can be your next meal, but be careful might be poisonous."));

            Locations.Add(new Locations("Forest","Peaceful forest with wild creatures", temp2, ConsoleColor.DarkGreen));

            List<Item> temp3 = new List<Item>();
            //desert - big rice bag, hat, waterbottle, compass, sunglasses
            temp3.Add(new Item("big rice bag", "great for sliding down the sandy hills."));
            temp3.Add(new Item("hat", "a cool looking hat and will need to block the sun."));
            temp3.Add(new Item("waterbottle", "still contain some water and will need later to stay hydrated."));
            temp3.Add(new Item("compass", "will need later if you get lost."));
            temp3.Add(new Item("sunglasses", "still usable and great for blocking the sun"));

            Locations.Add(new Locations("Dessert","Dry dessert with beautiful red sand", temp3, ConsoleColor.DarkRed));

            List<Item> temp4 = new List<Item>();
            //jungle - machete, ring, tooth, mango
            temp4.Add(new Item("machete", "still usable to chop down tall grasses."));
            temp4.Add(new Item("ring", "a shiny ring"));
            temp4.Add(new Item("tooth", "mystery tooth"));
            temp4.Add(new Item("mango", "looks good, but don't know if its safe to eat."));

            Locations.Add(new Locations("Jungle","Very humidity jungle with wired and wild creatures.", temp4, ConsoleColor.DarkMagenta));


        }
        private void SetUpPlayer() 
        {
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            //TODO: Get player information
            WriteLine("Hello explorer! What's your name?");
            string input = ReadLine();
            input = TitleCase.ToTitleCase(input);
            player = new Person(input, new List<Item>());
            WriteLine("Welcome\n" + player.Name);
        }
        private void LocationMenu() 
        {
            //TODO: Let player choose a location to explore
            WriteLine("These are the places you can visit... enter a number to travel:");
            int choice = 1;
            foreach(Locations location in Locations) 
            {
                WriteLine(choice +") " + location.About());
                choice++; 
            }
            string input = ReadLine();
            switch (input) 
            {
                case "1":
                    Travel(0);
                    break;

                case "2":
                    Travel(1);
                    break;

                case "3":
                    Travel(2);
                    break;

                case "4":

                    bool sunglasses = false;
                    bool hat = false;
                    bool axe = false;
                    foreach (Item item in player.Inventory)
                    {
                        if (item.Name.Contains("sunglasses"))
                        {
                            sunglasses = true;
                        }
                        else if (item.Name.Contains("hat"))
                        {
                            hat = true;
                        }
                        else if (item.Name.Contains("axe"))
                        {
                            axe = true;
                        }

                    }
                    if (sunglasses && hat && axe)
                    { Travel(3);}
                    else
                    {
                        WriteLine("You are missing essential gloves. Make sure you have the sunglasses, hat, and axe.");
                        WriteLine("Press any key to continue...");
                        ReadKey();
                    }
                    break;
            }
           

            ReadKey();
            LocationMenu();

        }
        private void Travel(int choice)
        {
            //let player explore
           
            BackgroundColor = Locations[choice].LocationColor;
            Clear(); 
            WriteLine($"Welcome {player.Name} to {Locations[choice].Name}");

            //text describing area
            WriteLine(Locations[choice].Description);

            //player find a random item
            Item randomItem = Locations[choice].Items[Utility.GetRandomNumber(Locations[choice].Items.Count)];

            //give player the choice of picking item up
            WriteLine($"You see a {randomItem.Name} ({randomItem.Description}) lying on the ground. Do you pick it up and take it with you?");
            string input = ReadLine();

            if (input.ToLower() == "yes")
            {
                player.Inventory.Add(randomItem);
            }

            WriteLine("Here is what is in your inventory:");
            foreach (Item item in player.Inventory)
            {
                WriteLine(item.Name);
            }
            WriteLine("Press any key to continue...");
            ReadKey();


          
            ReadKey();

        }
    }
}