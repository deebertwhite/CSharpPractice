using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Histogram
{
    class Methods
    {
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

        public static void ReadString(string Prompt, ref string Value)
        {
            bool Check = false;
            do
            {
                Console.Write($"{Prompt} ");
                Value = Console.ReadLine();
                if (string.IsNullOrEmpty(Value) == false)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer");
                }
            } while (Check == false);


        }


        public static void ReadChoice(string Prompt, string[] Options, out int Selection)
        {
            int Max = Options.Length;

            foreach (string Option in Options)
            {
                Console.WriteLine(Option);
            }

            Selection = ReadInteger(Prompt, 1, Max);

        }

        public static string GetSpeech()
        {
            StreamReader sr = new StreamReader(@"C:\Users\deebe\CSharpPractice\PG2\Data\speechString.txt");
            string speech = sr.ReadLine();
            while (speech != null)
            {
                Console.WriteLine(speech);
                speech = sr.ReadLine();
            }
            sr.Close();
            return speech;
        }
    }
}
