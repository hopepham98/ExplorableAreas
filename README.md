# ExplorableAreas :world_map:
This application was part of an assignment for my Summer 2020 Intro Programming class. An application enables the player to choose the places they want to explore and earn items for thier inventory.

## Assignment Challenge(s)
The biggest challenge that i encounter with this application was how to continue linking the class and method of the item with the list class and method. I also didn't understand the switch method, but I had help from my professor and the internet, which was awesome since I like the switch method now.

## Image of Application Intro:

![ExplorableAreasIntro](https://user-images.githubusercontent.com/67672827/88250299-beeda100-cc6c-11ea-86c6-9dc736db31b7.png)


## Example of Location Code:

```markdown
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
```
