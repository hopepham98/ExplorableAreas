using System;
using static System.Console;

/*
 * Explorable Areas by Hope Pham
 * PROG 101 (01) July 06, 2020
 * Title created at network-science.de
 * Assisted by Janell Baxter
 * Project: Code from GitHub page https://gist.github.com/janell-baxter/8edc43111d478bb60fd4bb7418643eeb
 * Code Author: https://gist.github.com/janell-baxter
 * 
 */

namespace ExplorableAreas
{
    class Program
    {
        static void Main()
        {

            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.Yellow;
            Clear();
            string TitleText = "Explorable Areas by Hope Pham";
            TitleText = @"

_______ _     _  _____          _____   ______ _______ ______         _______
  |______  \___/  |_____] |      |     | |_____/ |_____| |_____] |      |______
  |______ _/   \_ |       |_____ |_____| |    \_ |     | |_____] |_____ |______
                                                                               
                     _______  ______ _______ _______ _______
                     |_____| |_____/ |______ |_____| |______
                     |     | |    \_ |______ |     | ______|
                                                              
                               By Hope Pham
                         (press enter to explore)



";

            Title = "Explorable Areas by Hope Pham";
            Write(TitleText);

            ReadKey();
            Clear();

            new World();

        }
    }
}
