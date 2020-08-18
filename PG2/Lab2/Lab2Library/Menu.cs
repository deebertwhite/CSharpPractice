using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Library
{
    public class Menu
    {
        #region ReadInteger
        public static int ReadInteger(string Prompt, int Min, int Max)
        {
            string Answer = null;
            int Value = 0;
            bool isParsable = false;

            Console.Write($"{Prompt} ");
            Answer = Console.ReadLine();

            while (isParsable == false)
            {
                if (Int32.TryParse(Answer, out Value))
                {
                    if (Value >= Min && Value <= Max)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"Please enter a number between {Min} and {Max}: ");
                        Answer = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("Entry invalid. Please try again: ");
                    Answer = Console.ReadLine();
                }


            }

            return Value;

        }
        #endregion

        #region ReadChoice
        public static void ReadChoice(string Prompt, string[] Options, out int Selection)
        {
            int Max = Options.Length;

            foreach (string Option in Options)
            {
                Console.WriteLine(Option);
            }

            Selection = ReadInteger(Prompt, 1, Max);

        }
        #endregion
    }
}
