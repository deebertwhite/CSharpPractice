using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Histogram
{
    class Program
    {
        public static void Main()
        {
            string Speech = Methods.GetSpeech();
            char[] delimiters = new char[] { ' ', ',', '.', ':', '\t', '=', ';', '"', '+' };
            string[] splitSpeech = Speech.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<string> words = splitSpeech.ToList();

            Dictionary<string, int> wordCount = new Dictionary<string, int> { } ;


            bool mainMenuLoop = true;

            while (mainMenuLoop == true)
            {
                string ask = "What would you like to do? Please enter a number: ";
                string[] mainMenu = new string[] {"1. Show Histogram", "2. Search for Word", "3. Save Histogram", "4. Load Histogram", "5. Remove Word", "6. Exit" };
                int mainMenuChoice = 0;
                Methods.ReadChoice(ask, mainMenu, out mainMenuChoice);
                switch (mainMenuChoice)
                {
                    case 1:

                        break;
                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;

                    case 6:
                        mainMenuLoop = false;
                        break;

                }
            }
        }
    }
}
