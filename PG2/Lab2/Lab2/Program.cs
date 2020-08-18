using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Library;

namespace Lab2
{
    public class Program
    {
        static void Main()
        {

            bool mainMenuLoop = true;

            while (mainMenuLoop == true)
            {
                string ask = "What would you like to do? Please enter a number: ";
                string[] mainMenu = new string[] { "1. Play BlackJack", "2. Shuffle and Show", "3. Exit" };
                int mainMenuChoice = 0;
                Menu.ReadChoice(ask, mainMenu, out mainMenuChoice);
                switch (mainMenuChoice)
                {
                    case 1:

                        break;
                    case 2:
                        Deck deck = new Deck();
                        deck.Shuffle();
                        Console.Clear();
                        CardAppearance.DrawCard(deck);
                        break;

                    case 3:
                        mainMenuLoop = false;
                        break;

                }
            }    

        }
    }
}
